namespace Baufinanzierungsrechner.Model {
	public record Sondertilgung {
		public required double Prozent { get; init; }
		public required double Wert { get; init; }
	}
}
