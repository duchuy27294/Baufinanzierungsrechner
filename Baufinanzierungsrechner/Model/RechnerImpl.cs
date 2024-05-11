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
		private double tilgungsrate;
		private double monatsrate;
		private Tilgungsplan tilgungsplan;

		public event PropertyChangedEventHandler? PropertyChanged;

		public RechnerImpl(DateTime start, double kaufpreis, double eigenkapital, double grunderwerbssteuerProzent, double notarkostenProzent,
						  double grundbucheintragProzent, double maklerprovision, double anfangszinssatz, double zinssatz, double tilgungsrate) {
			this.start = start;
			this.kaufpreis = kaufpreis;
			this.eigenkapital = eigenkapital;
			this.grunderwerbssteuerProzent = grunderwerbssteuerProzent;
			this.notarkostenProzent = notarkostenProzent;
			this.grundbucheintragProzent = grundbucheintragProzent;
			this.maklerprovision = maklerprovision;
			this.anfangszinssatz = anfangszinssatz;
			this.zinssatz = zinssatz;
			this.tilgungsrate = tilgungsrate;
			this.monatsrate = (this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital) * (this.tilgungsrate + this.zinssatz) / (12 * 100);
			this.tilgungsplan = TilgungsplanFactory.CreateTilgungsplan(this.start, this.sollzinsbindungslaufzeit, this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital,
								this.monatsrate, this.zinssatz);
		}
		public DateTime Start {
			get => this.start;
			set {
				this.start = value;
				this.notifyPropertyChanged("Start");
			}
		}
		public double Kaufpreis {
			get => this.kaufpreis;
			set {
				this.kaufpreis = value;
				this.notifyPropertyChanged("Kaufpreis");
			}
		}
		public double Eigenkapital {
			get => this.eigenkapital;
			set {
				this.eigenkapital = value;
				this.notifyPropertyChanged("Eigenkapital");
			}
		}
		public double GrunderwerbssteuerProzent {
			get => this.grunderwerbssteuerProzent;
			set {
				this.grunderwerbssteuerProzent = value;
				this.notifyPropertyChanged("GrunderwerbssteuerProzent");
			}
		}
		public double Grunderwerbssteuer => (this.kaufpreis * this.grunderwerbssteuerProzent / 100);
		public double NotarkostenProzent {
			get => this.notarkostenProzent;
			set {
				this.notarkostenProzent = value;
				this.notifyPropertyChanged("NotarkostenProzent");
			}
		}
		public double Notarkosten => (this.kaufpreis * this.notarkostenProzent / 100);
		public double GrundbucheintragProzent {
			get => this.grundbucheintragProzent;
			set {
				this.grundbucheintragProzent = value;
				this.notifyPropertyChanged("GrundbucheintragProzent");
			}
		}
		public double Grundbucheintrag => (this.kaufpreis * this.grundbucheintragProzent / 100);
		public double Maklerprovision {
			get => this.maklerprovision;
			set {
				this.maklerprovision = value;
				this.notifyPropertyChanged("Maklerprovision");
			}
		}
		public double MaklerprovisionBetrag => (this.kaufpreis * this.maklerprovision / 100);
		public double Anfangszinssatz {
			get => this.anfangszinssatz;
			set {
				this.anfangszinssatz = value;
				this.notifyPropertyChanged("Anfangszinssatz");
			}
		}
		public double Zinssatz {
			get => this.zinssatz;
			set {
				this.zinssatz = value;
				this.notifyPropertyChanged("Zinssatz");
			}
		}
		public int Sollzinsbindungslaufzeit {
			get => this.sollzinsbindungslaufzeit;
			set {
				this.sollzinsbindungslaufzeit = value;
				this.notifyPropertyChanged("Sollzinsbindungslaufzeit");
			}
		}
		public double Tilgungsrate {
			get => this.tilgungsrate;
			set {
				tilgungsrate = value;
				monatsrate = (kaufpreis + Kaufnebenkosten - eigenkapital) * (tilgungsrate + zinssatz) / (12 * 100);
				this.tilgungsplan = TilgungsplanFactory.CreateTilgungsplan(this.start, this.sollzinsbindungslaufzeit, this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital,
								this.monatsrate, this.zinssatz);
				this.notifyPropertyChanged("Tilgungsrate");
			}
		}
		public double Monatsrate {
			get => this.monatsrate;
			set {
				monatsrate = value;
				tilgungsrate = (monatsrate * 12 * 100) / (kaufpreis + Kaufnebenkosten - eigenkapital) - zinssatz;
				this.tilgungsplan = TilgungsplanFactory.CreateTilgungsplan(this.start, this.sollzinsbindungslaufzeit, this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital,
								this.monatsrate, this.zinssatz);
				this.notifyPropertyChanged("Monatsrate");
			}
		}

		public DateTime EndSollzinsBindung { get => this.Start.AddYears(this.Sollzinsbindungslaufzeit); }

		public double Kaufnebenkosten => (Grunderwerbssteuer + Notarkosten + Grundbucheintrag + MaklerprovisionBetrag);

		public DateTime EndSollzinsbindung => Start.AddYears(Sollzinsbindungslaufzeit);

		public double Restschuld {
			//get => double.Round((Kaufpreis - Eigenkapital) - (Monatsrate * (Math.Pow(1 + Zinssatz / 100, Sollzinsbindungslaufzeit) - 1) / (Sollzinsbindungslaufzeit / 100)), 2);
			get => this.tilgungsplan.Restschuld;
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
			this.tilgungsrate = Rechner.STANDARD_TILGUNGSRATE_PROZENT;
			this.Sollzinsbindungslaufzeit = Rechner.STANDARD_SOLLZINSBINDUNGSLAUFZEIT;
			this.monatsrate = (this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital) * (this.tilgungsrate + this.zinssatz) / (12 * 100);
			this.tilgungsplan = TilgungsplanFactory.CreateTilgungsplan(this.start, this.sollzinsbindungslaufzeit, this.kaufpreis + this.Kaufnebenkosten - this.eigenkapital,
								this.monatsrate, this.zinssatz);
		}

		private void notifyPropertyChanged([CallerMemberName] string propertyName = "") {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
