using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baufinanzierungsrechner.Model {
	public static class MonatstilgungFactory {
		public static Monatstilgung CreatMonatstilgung(double raten, double zinsProzent, DateTime zeitpunkt, double restschuldVormonat) {
			return new MonatstilgungImpl(raten, zinsProzent, zeitpunkt, restschuldVormonat);
		}
	}
}
