using System.ComponentModel;
using Baufinanzierungsrechner.Model.Core;

namespace Baufinanzierungsrechner.Model {
	public interface Monatstilgung : INotifyPropertyChanged {
		public DateTime? Zeitpunkt { get; set; }
		public double Tilgung { get; }
		public Zins Zins { get; }
		public double RestschuldVormonat { get; set; }
		public double Restschuld { get; }
		public double Raten { get; }
	}
}
