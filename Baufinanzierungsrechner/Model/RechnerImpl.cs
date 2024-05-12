using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Baufinanzierungsrechner.Model {
	internal class RechnerImpl : Rechner {

		private DateTime start;
		private double kaufpreis;
		private double eigenkapital;
		private double grunderwerbssteuerProzent;
		private double notarkostenProzent;
		private double grundbucheintragProzent;
		private double maklerprovision;
		private double anfangszinssatz;
		private double zinssatz;
		private int sollzinsbindungslaufzeit;
		private double tilgungsrateProzent;
		private double jaehrlicheSondertilgung;
		private Tilgungsplan tilgungsplan;

		public event PropertyChangedEventHandler? PropertyChanged;
		public event EventHandler<Tilgungsplan>? TilgungsplanChanged;

		public RechnerImpl(DateTime start, double kaufpreis, double eigenkapital, double grunderwerbssteuerProzent, double notarkostenProzent,
						  double grundbucheintragProzent, double maklerprovision, double anfangszinssatz, double zinssatz, double tilgungsrateProzent,
						  double jaehrlicheSondertilgung = 0) {
			this.start = start;
			this.kaufpreis = kaufpreis;
			this.eigenkapital = eigenkapital;
			this.grunderwerbssteuerProzent = grunderwerbssteuerProzent;
			this.notarkostenProzent = notarkostenProzent;
			this.grundbucheintragProzent = grundbucheintragProzent;
			this.maklerprovision = maklerprovision;
			this.anfangszinssatz = anfangszinssatz;
			this.zinssatz = zinssatz;
			this.tilgungsrateProzent = tilgungsrateProzent;
			this.jaehrlicheSondertilgung = jaehrlicheSondertilgung;
			this.UpdateTilgungsplan();
		}

		public DateTime Start {
			get => this.start;
			set {
				this.start = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Start");
			}
		}
		public double Kaufpreis {
			get => this.kaufpreis;
			set {
				this.kaufpreis = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Kaufpreis");
			}
		}
		public double Eigenkapital {
			get => this.eigenkapital;
			set {
				this.eigenkapital = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Eigenkapital");
			}
		}
		public double GrunderwerbssteuerProzent {
			get => this.grunderwerbssteuerProzent;
			set {
				this.grunderwerbssteuerProzent = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("GrunderwerbssteuerProzent");
			}
		}
		public double Grunderwerbssteuer => (this.kaufpreis * this.grunderwerbssteuerProzent / 100);
		public double NotarkostenProzent {
			get => this.notarkostenProzent;
			set {
				this.notarkostenProzent = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("NotarkostenProzent");
			}
		}
		public double Notarkosten => (this.kaufpreis * this.notarkostenProzent / 100);
		public double GrundbucheintragProzent {
			get => this.grundbucheintragProzent;
			set {
				this.grundbucheintragProzent = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("GrundbucheintragProzent");
			}
		}
		public double Grundbucheintrag => (this.kaufpreis * this.grundbucheintragProzent / 100);
		public double Maklerprovision {
			get => this.maklerprovision;
			set {
				this.maklerprovision = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Maklerprovision");
			}
		}
		public double MaklerprovisionBetrag => (this.kaufpreis * this.maklerprovision / 100);
		public double Anfangszinssatz {
			get => this.anfangszinssatz;
			set {
				this.anfangszinssatz = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Anfangszinssatz");
			}
		}
		public double Zinssatz {
			get => this.zinssatz;
			set {
				this.zinssatz = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Zinssatz");
			}
		}
		public int Sollzinsbindungslaufzeit {
			get => this.sollzinsbindungslaufzeit;
			set {
				this.sollzinsbindungslaufzeit = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("Sollzinsbindungslaufzeit");
			}
		}
		public double TilgungsrateProzent {
			get => this.tilgungsrateProzent;
			set {
				this.tilgungsrateProzent = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("TilgungsrateProzent");
			}
		}
		public double Tilgungsrate {
			get => (this.kaufpreis + Kaufnebenkosten - this.eigenkapital) * (this.tilgungsrateProzent + zinssatz) / (12 * 100);
			set {
				this.tilgungsrateProzent = (value * 12 * 100) / (kaufpreis + Kaufnebenkosten - eigenkapital) - zinssatz;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("TilgungsrateProzent");
			}
		}

		public DateTime EndSollzinsBindung { get => this.Start.AddYears(this.Sollzinsbindungslaufzeit); }

		public double Kaufnebenkosten => (Grunderwerbssteuer + Notarkosten + Grundbucheintrag + MaklerprovisionBetrag);

		public DateTime EndSollzinsbindung => Start.AddYears(Sollzinsbindungslaufzeit);

		public double Restschuld {
			//get => double.Round((Kaufpreis - Eigenkapital) - (Monatsrate * (Math.Pow(1 + Zinssatz / 100, Sollzinsbindungslaufzeit) - 1) / (Sollzinsbindungslaufzeit / 100)), 2);
			get => this.tilgungsplan.Restschuld;
		}

		public double JaehrlicheSondertilgung {
			get => this.jaehrlicheSondertilgung;
			set {
				this.jaehrlicheSondertilgung = value;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("JaehrlicheSondertilgung");
			}
		}

		public double JaehrlicheSondertilgungProzent {
			get => (this.jaehrlicheSondertilgung / this.Nettodarlehen) * 100;
			set {
				this.jaehrlicheSondertilgung = this.Nettodarlehen * value / 100;
				this.UpdateTilgungsplan();
				this.notifyPropertyChanged("JaehrlicheSondertilgung");
			}
		}

		public double Nettodarlehen {
			get => (this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital);
		}

		public Tilgungsplan Tilgungsplan => this.tilgungsplan;

		public void StandardSetzen() {
			this.start = DateTime.Today;
			this.grunderwerbssteuerProzent = Rechner.STANDARD_GRUNDERWERBSSTEUER_PROZENT;
			this.notarkostenProzent = Rechner.STANDARD_NOTARKOSTEN_PROZENT;
			this.grundbucheintragProzent = Rechner.STANDARD_GRUNDBUCHEINTRAG_PROZENT;
			this.maklerprovision = Rechner.STANDARD_MAKLERPROVISION_PROZENT;
			this.anfangszinssatz = Rechner.STANDARD_ZINSSATZ_PROZENT;
			this.zinssatz = Rechner.STANDARD_ZINSSATZ_PROZENT;
			this.tilgungsrateProzent = Rechner.STANDARD_TILGUNGSRATE_PROZENT;
			this.Sollzinsbindungslaufzeit = Rechner.STANDARD_SOLLZINSBINDUNGSLAUFZEIT;
			this.tilgungsplan = TilgungsplanFactory.CreateTilgungsplan(this.start, this.sollzinsbindungslaufzeit,
								this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital, this.tilgungsrateProzent, this.zinssatz);
		}

		private void notifyPropertyChanged([CallerMemberName] string propertyName = "") {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private void UpdateTilgungsplan() {
			this.tilgungsplan = TilgungsplanFactory.CreateTilgungsplan(this.start, this.sollzinsbindungslaufzeit, this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital,
								this.Tilgungsrate, this.zinssatz, jaehrlicheSondertilgung);
			TilgungsplanChanged?.Invoke(this, this.tilgungsplan);
		}
	}
}
