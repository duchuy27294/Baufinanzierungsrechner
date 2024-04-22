namespace Baufinanzierungsrechner.Model {
	public interface Tilgungsplan {
		public DateTime Start { get; }
		public DateTime End { get; }
		public int Laufzeit { get; }
		public double Kredit { get; }
		public double Restschuld { get; }
		public List<Monatstilgung> Monatstilgung { get; }
		public double Raten { get; }
		public double Zinssatz { get; }
	}
}
