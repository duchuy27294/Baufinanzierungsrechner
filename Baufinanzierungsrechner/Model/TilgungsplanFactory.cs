namespace Baufinanzierungsrechner.Model {
	public static class TilgungsplanFactory {
		public static Tilgungsplan CreateTilgungsplan(DateTime start, int laufzeit, double kredit, double raten, double zinssatz, double jaehrlicheSondertilgung = 0) {
			return new TilgungsplanImpl(start, laufzeit, kredit, raten, zinssatz, jaehrlicheSondertilgung = 0);
		}
	}
}
