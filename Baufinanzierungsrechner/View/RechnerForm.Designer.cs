namespace Baufinanzierungsrechner.View {
	partial class RechnerForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			tableLayoutPanelMain = new TableLayoutPanel();
			tableLayoutInfo = new TableLayoutPanel();
			lbKaufpreis = new Label();
			tbKaufpreis = new TextBox();
			lblEigenkapital = new Label();
			tbEigenkapital = new TextBox();
			lbKaufnebekostenInfo = new Label();
			lbKaufnebekostenWertInfo = new Label();
			lbNettoDarlehen = new Label();
			lbNettoDarlehenWert = new Label();
			tableLayoutKaufnebenkostenMain = new TableLayoutPanel();
			lblKaufnebenkosten = new Label();
			tableLayoutKaufnebenkosten = new TableLayoutPanel();
			lblGrunderwebssteuer = new Label();
			lblNotarkosten = new Label();
			lblGrundbucheintrag = new Label();
			lblMaklerprovision = new Label();
			lbKaufnebenkostensumme = new Label();
			lbGrunderwerbssteuerWert = new Label();
			lbNotarkostenWert = new Label();
			lbGrundbucheintragWert = new Label();
			lbMaklerprovisionWert = new Label();
			lbKaufnebenkostensummeWert = new Label();
			tbGrunderwerbssteuerProzent = new TextBox();
			tbNotarkostenProzent = new TextBox();
			tbGrundbucheintragProzent = new TextBox();
			tbMaklerprovisionProzent = new TextBox();
			tableLayoutPanelMain.SuspendLayout();
			tableLayoutInfo.SuspendLayout();
			tableLayoutKaufnebenkostenMain.SuspendLayout();
			tableLayoutKaufnebenkosten.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			tableLayoutPanelMain.ColumnCount = 2;
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
			tableLayoutPanelMain.Controls.Add(tableLayoutInfo, 0, 0);
			tableLayoutPanelMain.Controls.Add(tableLayoutKaufnebenkostenMain, 1, 0);
			tableLayoutPanelMain.Dock = DockStyle.Fill;
			tableLayoutPanelMain.Location = new Point(0, 0);
			tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			tableLayoutPanelMain.RowCount = 2;
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Size = new Size(935, 732);
			tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutInfo
			// 
			tableLayoutInfo.ColumnCount = 2;
			tableLayoutInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutInfo.Controls.Add(lbKaufpreis, 0, 0);
			tableLayoutInfo.Controls.Add(tbKaufpreis, 1, 0);
			tableLayoutInfo.Controls.Add(lblEigenkapital, 0, 2);
			tableLayoutInfo.Controls.Add(tbEigenkapital, 1, 2);
			tableLayoutInfo.Controls.Add(lbKaufnebekostenInfo, 0, 1);
			tableLayoutInfo.Controls.Add(lbKaufnebekostenWertInfo, 1, 1);
			tableLayoutInfo.Controls.Add(lbNettoDarlehen, 0, 3);
			tableLayoutInfo.Controls.Add(lbNettoDarlehenWert, 1, 3);
			tableLayoutInfo.Dock = DockStyle.Fill;
			tableLayoutInfo.Location = new Point(3, 3);
			tableLayoutInfo.Name = "tableLayoutInfo";
			tableLayoutInfo.RowCount = 4;
			tableLayoutInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutInfo.Size = new Size(419, 360);
			tableLayoutInfo.TabIndex = 0;
			// 
			// lbKaufpreis
			// 
			lbKaufpreis.Anchor = AnchorStyles.Right;
			lbKaufpreis.AutoSize = true;
			lbKaufpreis.Location = new Point(66, 17);
			lbKaufpreis.Name = "lbKaufpreis";
			lbKaufpreis.Size = new Size(56, 15);
			lbKaufpreis.TabIndex = 0;
			lbKaufpreis.Text = "Kaufpreis";
			lbKaufpreis.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbKaufpreis
			// 
			tbKaufpreis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbKaufpreis.Location = new Point(128, 13);
			tbKaufpreis.Name = "tbKaufpreis";
			tbKaufpreis.Size = new Size(288, 23);
			tbKaufpreis.TabIndex = 1;
			// 
			// lblEigenkapital
			// 
			lblEigenkapital.Anchor = AnchorStyles.Right;
			lblEigenkapital.AutoSize = true;
			lblEigenkapital.Location = new Point(43, 117);
			lblEigenkapital.Name = "lblEigenkapital";
			lblEigenkapital.Size = new Size(79, 15);
			lblEigenkapital.TabIndex = 2;
			lblEigenkapital.Text = "- Eigenkapital";
			lblEigenkapital.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbEigenkapital
			// 
			tbEigenkapital.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbEigenkapital.Location = new Point(128, 113);
			tbEigenkapital.Name = "tbEigenkapital";
			tbEigenkapital.Size = new Size(288, 23);
			tbEigenkapital.TabIndex = 3;
			// 
			// lbKaufnebekostenInfo
			// 
			lbKaufnebekostenInfo.Anchor = AnchorStyles.Right;
			lbKaufnebekostenInfo.AutoSize = true;
			lbKaufnebekostenInfo.Location = new Point(12, 67);
			lbKaufnebekostenInfo.Name = "lbKaufnebekostenInfo";
			lbKaufnebekostenInfo.Size = new Size(110, 15);
			lbKaufnebekostenInfo.TabIndex = 4;
			lbKaufnebekostenInfo.Text = "+ Kaufnebenkosten";
			lbKaufnebekostenInfo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbKaufnebekostenWertInfo
			// 
			lbKaufnebekostenWertInfo.Anchor = AnchorStyles.Right;
			lbKaufnebekostenWertInfo.AutoSize = true;
			lbKaufnebekostenWertInfo.Location = new Point(403, 67);
			lbKaufnebekostenWertInfo.Name = "lbKaufnebekostenWertInfo";
			lbKaufnebekostenWertInfo.Size = new Size(13, 15);
			lbKaufnebekostenWertInfo.TabIndex = 5;
			lbKaufnebekostenWertInfo.Text = "€";
			lbKaufnebekostenWertInfo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbNettoDarlehen
			// 
			lbNettoDarlehen.Anchor = AnchorStyles.Right;
			lbNettoDarlehen.AutoSize = true;
			lbNettoDarlehen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lbNettoDarlehen.Location = new Point(22, 247);
			lbNettoDarlehen.Name = "lbNettoDarlehen";
			lbNettoDarlehen.Size = new Size(100, 15);
			lbNettoDarlehen.TabIndex = 6;
			lbNettoDarlehen.Text = "= Nettodarlehen";
			lbNettoDarlehen.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbNettoDarlehenWert
			// 
			lbNettoDarlehenWert.Anchor = AnchorStyles.Right;
			lbNettoDarlehenWert.AutoSize = true;
			lbNettoDarlehenWert.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lbNettoDarlehenWert.Location = new Point(402, 247);
			lbNettoDarlehenWert.Name = "lbNettoDarlehenWert";
			lbNettoDarlehenWert.Size = new Size(14, 15);
			lbNettoDarlehenWert.TabIndex = 7;
			lbNettoDarlehenWert.Text = "€";
			lbNettoDarlehenWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tableLayoutKaufnebenkostenMain
			// 
			tableLayoutKaufnebenkostenMain.ColumnCount = 1;
			tableLayoutKaufnebenkostenMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutKaufnebenkostenMain.Controls.Add(lblKaufnebenkosten, 0, 0);
			tableLayoutKaufnebenkostenMain.Controls.Add(tableLayoutKaufnebenkosten, 0, 1);
			tableLayoutKaufnebenkostenMain.Dock = DockStyle.Fill;
			tableLayoutKaufnebenkostenMain.Location = new Point(428, 3);
			tableLayoutKaufnebenkostenMain.Name = "tableLayoutKaufnebenkostenMain";
			tableLayoutKaufnebenkostenMain.RowCount = 3;
			tableLayoutKaufnebenkostenMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkostenMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutKaufnebenkostenMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkostenMain.Size = new Size(504, 360);
			tableLayoutKaufnebenkostenMain.TabIndex = 1;
			// 
			// lblKaufnebenkosten
			// 
			lblKaufnebenkosten.AutoSize = true;
			lblKaufnebenkosten.Dock = DockStyle.Fill;
			lblKaufnebenkosten.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblKaufnebenkosten.Location = new Point(3, 0);
			lblKaufnebenkosten.Name = "lblKaufnebenkosten";
			lblKaufnebenkosten.Size = new Size(498, 40);
			lblKaufnebenkosten.TabIndex = 0;
			lblKaufnebenkosten.Text = "Kaufnebenkosten";
			lblKaufnebenkosten.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutKaufnebenkosten
			// 
			tableLayoutKaufnebenkosten.BackColor = SystemColors.Control;
			tableLayoutKaufnebenkosten.ColumnCount = 3;
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.62228F));
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8539F));
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.523819F));
			tableLayoutKaufnebenkosten.Controls.Add(lblGrunderwebssteuer, 0, 0);
			tableLayoutKaufnebenkosten.Controls.Add(lblNotarkosten, 0, 1);
			tableLayoutKaufnebenkosten.Controls.Add(lblGrundbucheintrag, 0, 2);
			tableLayoutKaufnebenkosten.Controls.Add(lblMaklerprovision, 0, 3);
			tableLayoutKaufnebenkosten.Controls.Add(lbKaufnebenkostensumme, 0, 4);
			tableLayoutKaufnebenkosten.Controls.Add(lbGrunderwerbssteuerWert, 1, 0);
			tableLayoutKaufnebenkosten.Controls.Add(lbNotarkostenWert, 1, 1);
			tableLayoutKaufnebenkosten.Controls.Add(lbGrundbucheintragWert, 1, 2);
			tableLayoutKaufnebenkosten.Controls.Add(lbMaklerprovisionWert, 1, 3);
			tableLayoutKaufnebenkosten.Controls.Add(lbKaufnebenkostensummeWert, 1, 4);
			tableLayoutKaufnebenkosten.Controls.Add(tbGrunderwerbssteuerProzent, 2, 0);
			tableLayoutKaufnebenkosten.Controls.Add(tbNotarkostenProzent, 2, 1);
			tableLayoutKaufnebenkosten.Controls.Add(tbGrundbucheintragProzent, 2, 2);
			tableLayoutKaufnebenkosten.Controls.Add(tbMaklerprovisionProzent, 2, 3);
			tableLayoutKaufnebenkosten.Dock = DockStyle.Fill;
			tableLayoutKaufnebenkosten.Location = new Point(3, 43);
			tableLayoutKaufnebenkosten.MaximumSize = new Size(0, 206);
			tableLayoutKaufnebenkosten.MinimumSize = new Size(0, 206);
			tableLayoutKaufnebenkosten.Name = "tableLayoutKaufnebenkosten";
			tableLayoutKaufnebenkosten.RowCount = 5;
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkosten.Size = new Size(498, 206);
			tableLayoutKaufnebenkosten.TabIndex = 1;
			// 
			// lblGrunderwebssteuer
			// 
			lblGrunderwebssteuer.Anchor = AnchorStyles.Right;
			lblGrunderwebssteuer.AutoSize = true;
			lblGrunderwebssteuer.Location = new Point(41, 12);
			lblGrunderwebssteuer.Name = "lblGrunderwebssteuer";
			lblGrunderwebssteuer.Size = new Size(113, 15);
			lblGrunderwebssteuer.TabIndex = 0;
			lblGrunderwebssteuer.Text = "Grunderwerbssteuer";
			lblGrunderwebssteuer.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblNotarkosten
			// 
			lblNotarkosten.Anchor = AnchorStyles.Right;
			lblNotarkosten.AutoSize = true;
			lblNotarkosten.Location = new Point(82, 52);
			lblNotarkosten.Name = "lblNotarkosten";
			lblNotarkosten.Size = new Size(72, 15);
			lblNotarkosten.TabIndex = 1;
			lblNotarkosten.Text = "Notarkosten";
			// 
			// lblGrundbucheintrag
			// 
			lblGrundbucheintrag.Anchor = AnchorStyles.Right;
			lblGrundbucheintrag.AutoSize = true;
			lblGrundbucheintrag.Location = new Point(50, 92);
			lblGrundbucheintrag.Name = "lblGrundbucheintrag";
			lblGrundbucheintrag.Size = new Size(104, 15);
			lblGrundbucheintrag.TabIndex = 2;
			lblGrundbucheintrag.Text = "Grundbucheintrag";
			// 
			// lblMaklerprovision
			// 
			lblMaklerprovision.Anchor = AnchorStyles.Right;
			lblMaklerprovision.AutoSize = true;
			lblMaklerprovision.Location = new Point(62, 132);
			lblMaklerprovision.Name = "lblMaklerprovision";
			lblMaklerprovision.Size = new Size(92, 15);
			lblMaklerprovision.TabIndex = 3;
			lblMaklerprovision.Text = "Maklerprovision";
			// 
			// lbKaufnebenkostensumme
			// 
			lbKaufnebenkostensumme.Anchor = AnchorStyles.Right;
			lbKaufnebenkostensumme.AutoSize = true;
			lbKaufnebenkostensumme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lbKaufnebenkostensumme.Location = new Point(7, 175);
			lbKaufnebenkostensumme.Name = "lbKaufnebenkostensumme";
			lbKaufnebenkostensumme.Size = new Size(147, 15);
			lbKaufnebenkostensumme.TabIndex = 4;
			lbKaufnebenkostensumme.Text = "Kaufnebenkostensumme";
			// 
			// lbGrunderwerbssteuerWert
			// 
			lbGrunderwerbssteuerWert.Anchor = AnchorStyles.Right;
			lbGrunderwerbssteuerWert.AutoSize = true;
			lbGrunderwerbssteuerWert.Location = new Point(369, 12);
			lbGrunderwerbssteuerWert.Name = "lbGrunderwerbssteuerWert";
			lbGrunderwerbssteuerWert.Size = new Size(13, 15);
			lbGrunderwerbssteuerWert.TabIndex = 5;
			lbGrunderwerbssteuerWert.Text = "€";
			lbGrunderwerbssteuerWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbNotarkostenWert
			// 
			lbNotarkostenWert.Anchor = AnchorStyles.Right;
			lbNotarkostenWert.AutoSize = true;
			lbNotarkostenWert.Location = new Point(369, 52);
			lbNotarkostenWert.Name = "lbNotarkostenWert";
			lbNotarkostenWert.Size = new Size(13, 15);
			lbNotarkostenWert.TabIndex = 6;
			lbNotarkostenWert.Text = "€";
			lbNotarkostenWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbGrundbucheintragWert
			// 
			lbGrundbucheintragWert.Anchor = AnchorStyles.Right;
			lbGrundbucheintragWert.AutoSize = true;
			lbGrundbucheintragWert.Location = new Point(369, 92);
			lbGrundbucheintragWert.Name = "lbGrundbucheintragWert";
			lbGrundbucheintragWert.Size = new Size(13, 15);
			lbGrundbucheintragWert.TabIndex = 7;
			lbGrundbucheintragWert.Text = "€";
			lbGrundbucheintragWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbMaklerprovisionWert
			// 
			lbMaklerprovisionWert.Anchor = AnchorStyles.Right;
			lbMaklerprovisionWert.AutoSize = true;
			lbMaklerprovisionWert.Location = new Point(369, 132);
			lbMaklerprovisionWert.Name = "lbMaklerprovisionWert";
			lbMaklerprovisionWert.Size = new Size(13, 15);
			lbMaklerprovisionWert.TabIndex = 8;
			lbMaklerprovisionWert.Text = "€";
			lbMaklerprovisionWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbKaufnebenkostensummeWert
			// 
			lbKaufnebenkostensummeWert.Anchor = AnchorStyles.Right;
			lbKaufnebenkostensummeWert.AutoSize = true;
			lbKaufnebenkostensummeWert.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lbKaufnebenkostensummeWert.Location = new Point(368, 175);
			lbKaufnebenkostensummeWert.Name = "lbKaufnebenkostensummeWert";
			lbKaufnebenkostensummeWert.Size = new Size(14, 15);
			lbKaufnebenkostensummeWert.TabIndex = 9;
			lbKaufnebenkostensummeWert.Text = "€";
			lbKaufnebenkostensummeWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbGrunderwerbssteuerProzent
			// 
			tbGrunderwerbssteuerProzent.Anchor = AnchorStyles.Right;
			tbGrunderwerbssteuerProzent.Location = new Point(395, 8);
			tbGrunderwerbssteuerProzent.Name = "tbGrunderwerbssteuerProzent";
			tbGrunderwerbssteuerProzent.Size = new Size(100, 23);
			tbGrunderwerbssteuerProzent.TabIndex = 10;
			tbGrunderwerbssteuerProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// tbNotarkostenProzent
			// 
			tbNotarkostenProzent.Anchor = AnchorStyles.Right;
			tbNotarkostenProzent.Location = new Point(395, 48);
			tbNotarkostenProzent.Name = "tbNotarkostenProzent";
			tbNotarkostenProzent.Size = new Size(100, 23);
			tbNotarkostenProzent.TabIndex = 11;
			tbNotarkostenProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// tbGrundbucheintragProzent
			// 
			tbGrundbucheintragProzent.Anchor = AnchorStyles.Right;
			tbGrundbucheintragProzent.Location = new Point(395, 88);
			tbGrundbucheintragProzent.Name = "tbGrundbucheintragProzent";
			tbGrundbucheintragProzent.Size = new Size(100, 23);
			tbGrundbucheintragProzent.TabIndex = 12;
			tbGrundbucheintragProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// tbMaklerprovisionProzent
			// 
			tbMaklerprovisionProzent.Anchor = AnchorStyles.Right;
			tbMaklerprovisionProzent.Location = new Point(395, 128);
			tbMaklerprovisionProzent.Name = "tbMaklerprovisionProzent";
			tbMaklerprovisionProzent.Size = new Size(100, 23);
			tbMaklerprovisionProzent.TabIndex = 13;
			tbMaklerprovisionProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// RechnerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(935, 732);
			Controls.Add(tableLayoutPanelMain);
			MinimumSize = new Size(0, 560);
			Name = "RechnerForm";
			Text = "Baufinanzierungsrechner";
			tableLayoutPanelMain.ResumeLayout(false);
			tableLayoutInfo.ResumeLayout(false);
			tableLayoutInfo.PerformLayout();
			tableLayoutKaufnebenkostenMain.ResumeLayout(false);
			tableLayoutKaufnebenkostenMain.PerformLayout();
			tableLayoutKaufnebenkosten.ResumeLayout(false);
			tableLayoutKaufnebenkosten.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutInfo;
		private Label lbKaufpreis;
		private TextBox tbKaufpreis;
		private Label lblEigenkapital;
		private TextBox tbEigenkapital;
		private TableLayoutPanel tableLayoutKaufnebenkostenMain;
		private Label lblKaufnebenkosten;
		private TableLayoutPanel tableLayoutKaufnebenkosten;
		private Label lblGrunderwebssteuer;
		private Label lblNotarkosten;
		private Label lblGrundbucheintrag;
		private Label lblMaklerprovision;
		private Label lbKaufnebenkostensumme;
		private Label lbGrunderwerbssteuerWert;
		private Label lbNotarkostenWert;
		private Label lbGrundbucheintragWert;
		private Label lbMaklerprovisionWert;
		private Label lbKaufnebenkostensummeWert;
		private TextBox tbGrunderwerbssteuerProzent;
		private TextBox tbNotarkostenProzent;
		private TextBox tbGrundbucheintragProzent;
		private TextBox tbMaklerprovisionProzent;
		private Label lbKaufnebekostenInfo;
		private Label lbKaufnebekostenWertInfo;
		private Label lbNettoDarlehen;
		private Label lbNettoDarlehenWert;
	}
}