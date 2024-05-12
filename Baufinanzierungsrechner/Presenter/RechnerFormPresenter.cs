using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baufinanzierungsrechner.Model;
using Baufinanzierungsrechner.View;

namespace Baufinanzierungsrechner.Presenter {
	public class RechnerFormPresenter {
		private Rechner model;
		private RechnerForm view;

		public RechnerFormPresenter(Rechner model, RechnerForm view) {
			this.model = model;
			this.view = view;
			this.Setup();
			this.RegisterEvents();
		}

		private void Setup() {
			this.view.PmSollzinsbindung.Unit = "Jahre";
			this.view.PmTilgungsrate.Unit = "%";
			this.SetupDataGridView();
			this.SetupData();
		}

		private void SetupDataGridView() {
			this.view.Tilgungsplan.ColumnCount = 6;
			string[] columnsNames = { "Periode", "Raten", "Zinsen", "Tilgung", "Sondertilgung", "Restschuld" };
			for (int i = 0; i < this.view.Tilgungsplan.ColumnCount; i++) {
				this.view.Tilgungsplan.Columns[i].Name = columnsNames[i];
			}
		}

		private void SetupData() {
			this.view.TbGrunderwerbssteuerProzent.Text = this.model.GrunderwerbssteuerProzent.ToString() + " %";
			this.view.TbNotarkostenProzent.Text = this.model.NotarkostenProzent.ToString() + " %";
			this.view.TbGrundbucheintragProzent.Text = this.model.GrundbucheintragProzent.ToString() + " %";
			this.view.TbMaklerprovisionProzent.Text = this.model.Maklerprovision.ToString() + " %";
		}

		private void RegisterEvents() {

		}
	}
}
