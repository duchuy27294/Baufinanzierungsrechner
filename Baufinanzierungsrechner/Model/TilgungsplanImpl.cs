namespace Baufinanzierungsrechner.Model {
	internal class TilgungsplanImpl : Tilgungsplan {
		private DateTime start;
		private int laufzeit;
		private double kredit;
		private List<Monatstilgung> monatstilgung;
		private double raten;
		private double zinssatz;

		public TilgungsplanImpl(DateTime start, int laufzeit, double kredit, double raten, double zinssatz) {
			this.start = start;
			this.laufzeit = laufzeit;
			this.kredit = kredit;
			this.raten = raten;
			this.zinssatz = zinssatz;
			this.monatstilgung = CreateMonatstilgung();
		}

		public DateTime Start => this.start;

		public DateTime End => this.start.AddYears(this.laufzeit);

		public double Kredit => this.kredit;

		public double Restschuld => this.monatstilgung.Last().Restschuld;

		public List<Monatstilgung> Monatstilgung => this.monatstilgung;

		public int Laufzeit => this.laufzeit;

		public double Raten => this.raten;

		public double Zinssatz => this.zinssatz;

		private List<Monatstilgung> CreateMonatstilgung() {
			List<Monatstilgung> mntg = new List<Monatstilgung>();
			for (int i = 0; i < (this.laufzeit/12); i++) {
				if (i == 0) {
					mntg.Add(MonatstilgungFactory.CreatMonatstilgung(this.raten, this.zinssatz, this.start, this.kredit));
				}
				else {
					mntg.Add(MonatstilgungFactory.CreatMonatstilgung(this.raten, this.zinssatz, this.start, mntg[i-1].Restschuld));
				}
			}
			return mntg;
		}
	}
}
