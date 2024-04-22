using Baufinanzierungsrechner.Model.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Baufinanzierungsrechner.Model {
	internal class MonatstilgungImpl : Monatstilgung {
		private double raten;
		private double tilgung;
		private Zins zins;
		private DateTime? zeitpunkt;
		private double restschuldVormonat;

		public event PropertyChangedEventHandler? PropertyChanged;

		public MonatstilgungImpl(double raten, double zinsProzent, DateTime zeitpunkt, double restschuldVormonat) {
			this.raten = raten;
			this.restschuldVormonat = restschuldVormonat;
			this.zins = this.ZinsBerechnen(zinsProzent, restschuldVormonat);
			this.zeitpunkt = zeitpunkt;
			this.tilgung = this.raten - zins.Wert;
			this.zeitpunkt = zeitpunkt;
		}

		public double Tilgung=> this.tilgung;

		public Zins Zins => this.zins;

		public DateTime? Zeitpunkt {
			get => this.zeitpunkt;
			set {
				this.zeitpunkt = value;
				this.notifyPropertyChanged("Zeitpunkt");
			}
		}
		public double RestschuldVormonat {
			get => this.restschuldVormonat;
			set {
				this.restschuldVormonat = value;
				this.notifyPropertyChanged("RestschuldVormonat");
				this.zins = this.ZinsBerechnen(this.zins.Prozent, restschuldVormonat);
				this.notifyPropertyChanged("Zins");
				this.tilgung = this.raten - this.zins.Wert;
				this.notifyPropertyChanged("Tilgung");
			}
		}

		public double Restschuld => (this.RestschuldVormonat - this.Raten + this.zins.Wert);

		public double Raten => this.raten;

		private Zins ZinsBerechnen(double zinsProzent, double restschuldVormonat) {
			return new Zins() {
				Prozent = zinsProzent,
				Wert = double.Round((restschuldVormonat * zinsProzent) / (100 * 12), 2)
			};
		}

		private void notifyPropertyChanged([CallerMemberName] string propertyName = "") {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

	}
}
