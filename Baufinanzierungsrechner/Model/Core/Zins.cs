namespace Baufinanzierungsrechner.Model.Core {
	public record Zins {
		public required double Prozent { get; init; }
		public required double Wert { get; init; }
	}
}
