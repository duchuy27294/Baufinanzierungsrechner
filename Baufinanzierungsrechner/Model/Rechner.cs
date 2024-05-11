using System.ComponentModel;

namespace Baufinanzierungsrechner.Model {
	public interface Rechner : INotifyPropertyChanged {
		DateTime Start { get; set; }
		DateTime EndSollzinsbindung { get; }
		public double Kaufpreis { get; set; }
		public double Eigenkapital { get; set; }
		public double GrunderwerbssteuerProzent { get; set; }
		public double Grunderwerbssteuer { get; }
		public double NotarkostenProzent {  get; set; }
		public double Notarkosten { get; }
		public double GrundbucheintragProzent {  get; set; }
		public double Grundbucheintrag { get; }
		public double Maklerprovision {  get; set; }
		public double MaklerprovisionBetrag { get; }
		public double Anfangszinssatz {  get; set; }
		public double Zinssatz {  get; set; }
		public int Sollzinsbindungslaufzeit { get; set; }
		public double Tilgungsrate { get; set; }
		public double TilgungsrateProzent { get; set; }
		public double Kaufnebenkosten {  get; }
		public double Restschuld { get; }
		public double JaehrlicheSondertilgung { get; set; }
		public double JaehrlicheSondertilgungProzent { get; set; }
		public Tilgungsplan Tilgungsplan { get; }
		public double Nettodarlehen { get; }
		public void StandardSetzen();

		public const double STANDARD_GRUNDERWERBSSTEUER_PROZENT = 3.5;
		public const double STANDARD_NOTARKOSTEN_PROZENT = 1.5;
		public const double STANDARD_GRUNDBUCHEINTRAG_PROZENT = 0.5;
		public const double STANDARD_MAKLERPROVISION_PROZENT = 3.57;
		public const double STANDARD_ZINSSATZ_PROZENT = 3.5;
		public const int STANDARD_SOLLZINSBINDUNGSLAUFZEIT = 10;
		public const double STANDARD_TILGUNGSRATE_PROZENT = 1;
	}
}
