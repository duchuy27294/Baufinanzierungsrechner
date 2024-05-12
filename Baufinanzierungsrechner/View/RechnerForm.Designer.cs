using Baufinanzierungsrechner.View.UserControl;

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
			layoutMonatsrate = new TableLayoutPanel();
			layoutTilgungsrate = new TableLayoutPanel();
			lbTilgungsrate = new Label();
			pmTilgungsrate = new PlusMinusControl();
			lbSollzinsbindung = new Label();
			pmSollzinsbindung = new PlusMinusControl();
			lbSollzins = new Label();
			tbSollzins = new TextBox();
			lbMonatsrate = new Label();
			tbMonatsrate = new TextBox();
			tilgungsplan = new DataGridView();
			tableLayoutPanelMain.SuspendLayout();
			tableLayoutInfo.SuspendLayout();
			tableLayoutKaufnebenkostenMain.SuspendLayout();
			tableLayoutKaufnebenkosten.SuspendLayout();
			layoutMonatsrate.SuspendLayout();
			layoutTilgungsrate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tilgungsplan).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			tableLayoutPanelMain.ColumnCount = 2;
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
			tableLayoutPanelMain.Controls.Add(tableLayoutInfo, 0, 0);
			tableLayoutPanelMain.Controls.Add(tableLayoutKaufnebenkostenMain, 1, 0);
			tableLayoutPanelMain.Controls.Add(layoutMonatsrate, 0, 1);
			tableLayoutPanelMain.Controls.Add(tilgungsplan, 1, 1);
			tableLayoutPanelMain.Dock = DockStyle.Fill;
			tableLayoutPanelMain.Location = new Point(0, 0);
			tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			tableLayoutPanelMain.RowCount = 2;
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Size = new Size(944, 521);
			tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutInfo
			// 
			tableLayoutInfo.ColumnCount = 2;
			tableLayoutInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			tableLayoutInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
			tableLayoutInfo.Size = new Size(419, 254);
			tableLayoutInfo.TabIndex = 0;
			// 
			// lbKaufpreis
			// 
			lbKaufpreis.Anchor = AnchorStyles.Right;
			lbKaufpreis.AutoSize = true;
			lbKaufpreis.Location = new Point(61, 17);
			lbKaufpreis.Name = "lbKaufpreis";
			lbKaufpreis.Size = new Size(56, 15);
			lbKaufpreis.TabIndex = 0;
			lbKaufpreis.Text = "Kaufpreis";
			lbKaufpreis.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbKaufpreis
			// 
			tbKaufpreis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbKaufpreis.Location = new Point(123, 13);
			tbKaufpreis.Name = "tbKaufpreis";
			tbKaufpreis.Size = new Size(293, 23);
			tbKaufpreis.TabIndex = 1;
			// 
			// lblEigenkapital
			// 
			lblEigenkapital.Anchor = AnchorStyles.Right;
			lblEigenkapital.AutoSize = true;
			lblEigenkapital.Location = new Point(38, 117);
			lblEigenkapital.Name = "lblEigenkapital";
			lblEigenkapital.Size = new Size(79, 15);
			lblEigenkapital.TabIndex = 2;
			lblEigenkapital.Text = "- Eigenkapital";
			lblEigenkapital.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbEigenkapital
			// 
			tbEigenkapital.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbEigenkapital.Location = new Point(123, 113);
			tbEigenkapital.Name = "tbEigenkapital";
			tbEigenkapital.Size = new Size(293, 23);
			tbEigenkapital.TabIndex = 3;
			// 
			// lbKaufnebekostenInfo
			// 
			lbKaufnebekostenInfo.Anchor = AnchorStyles.Right;
			lbKaufnebekostenInfo.AutoSize = true;
			lbKaufnebekostenInfo.Location = new Point(7, 67);
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
			lbNettoDarlehen.Location = new Point(17, 194);
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
			lbNettoDarlehenWert.Location = new Point(402, 194);
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
			tableLayoutKaufnebenkostenMain.Size = new Size(513, 254);
			tableLayoutKaufnebenkostenMain.TabIndex = 1;
			// 
			// lblKaufnebenkosten
			// 
			lblKaufnebenkosten.AutoSize = true;
			lblKaufnebenkosten.Dock = DockStyle.Fill;
			lblKaufnebenkosten.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblKaufnebenkosten.Location = new Point(3, 0);
			lblKaufnebenkosten.Name = "lblKaufnebenkosten";
			lblKaufnebenkosten.Size = new Size(507, 40);
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
			tableLayoutKaufnebenkosten.Size = new Size(507, 206);
			tableLayoutKaufnebenkosten.TabIndex = 1;
			// 
			// lblGrunderwebssteuer
			// 
			lblGrunderwebssteuer.Anchor = AnchorStyles.Right;
			lblGrunderwebssteuer.AutoSize = true;
			lblGrunderwebssteuer.Location = new Point(44, 12);
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
			lblNotarkosten.Location = new Point(85, 52);
			lblNotarkosten.Name = "lblNotarkosten";
			lblNotarkosten.Size = new Size(72, 15);
			lblNotarkosten.TabIndex = 1;
			lblNotarkosten.Text = "Notarkosten";
			// 
			// lblGrundbucheintrag
			// 
			lblGrundbucheintrag.Anchor = AnchorStyles.Right;
			lblGrundbucheintrag.AutoSize = true;
			lblGrundbucheintrag.Location = new Point(53, 92);
			lblGrundbucheintrag.Name = "lblGrundbucheintrag";
			lblGrundbucheintrag.Size = new Size(104, 15);
			lblGrundbucheintrag.TabIndex = 2;
			lblGrundbucheintrag.Text = "Grundbucheintrag";
			// 
			// lblMaklerprovision
			// 
			lblMaklerprovision.Anchor = AnchorStyles.Right;
			lblMaklerprovision.AutoSize = true;
			lblMaklerprovision.Location = new Point(65, 132);
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
			lbKaufnebenkostensumme.Location = new Point(10, 175);
			lbKaufnebenkostensumme.Name = "lbKaufnebenkostensumme";
			lbKaufnebenkostensumme.Size = new Size(147, 15);
			lbKaufnebenkostensumme.TabIndex = 4;
			lbKaufnebenkostensumme.Text = "Kaufnebenkostensumme";
			// 
			// lbGrunderwerbssteuerWert
			// 
			lbGrunderwerbssteuerWert.Anchor = AnchorStyles.Right;
			lbGrunderwerbssteuerWert.AutoSize = true;
			lbGrunderwerbssteuerWert.Location = new Point(376, 12);
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
			lbNotarkostenWert.Location = new Point(376, 52);
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
			lbGrundbucheintragWert.Location = new Point(376, 92);
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
			lbMaklerprovisionWert.Location = new Point(376, 132);
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
			lbKaufnebenkostensummeWert.Location = new Point(375, 175);
			lbKaufnebenkostensummeWert.Name = "lbKaufnebenkostensummeWert";
			lbKaufnebenkostensummeWert.Size = new Size(14, 15);
			lbKaufnebenkostensummeWert.TabIndex = 9;
			lbKaufnebenkostensummeWert.Text = "€";
			lbKaufnebenkostensummeWert.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbGrunderwerbssteuerProzent
			// 
			tbGrunderwerbssteuerProzent.Anchor = AnchorStyles.Right;
			tbGrunderwerbssteuerProzent.Location = new Point(404, 8);
			tbGrunderwerbssteuerProzent.Name = "tbGrunderwerbssteuerProzent";
			tbGrunderwerbssteuerProzent.Size = new Size(100, 23);
			tbGrunderwerbssteuerProzent.TabIndex = 10;
			tbGrunderwerbssteuerProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// tbNotarkostenProzent
			// 
			tbNotarkostenProzent.Anchor = AnchorStyles.Right;
			tbNotarkostenProzent.Location = new Point(404, 48);
			tbNotarkostenProzent.Name = "tbNotarkostenProzent";
			tbNotarkostenProzent.Size = new Size(100, 23);
			tbNotarkostenProzent.TabIndex = 11;
			tbNotarkostenProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// tbGrundbucheintragProzent
			// 
			tbGrundbucheintragProzent.Anchor = AnchorStyles.Right;
			tbGrundbucheintragProzent.Location = new Point(404, 88);
			tbGrundbucheintragProzent.Name = "tbGrundbucheintragProzent";
			tbGrundbucheintragProzent.Size = new Size(100, 23);
			tbGrundbucheintragProzent.TabIndex = 12;
			tbGrundbucheintragProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// tbMaklerprovisionProzent
			// 
			tbMaklerprovisionProzent.Anchor = AnchorStyles.Right;
			tbMaklerprovisionProzent.Location = new Point(404, 128);
			tbMaklerprovisionProzent.Name = "tbMaklerprovisionProzent";
			tbMaklerprovisionProzent.Size = new Size(100, 23);
			tbMaklerprovisionProzent.TabIndex = 13;
			tbMaklerprovisionProzent.TextAlign = HorizontalAlignment.Right;
			// 
			// layoutMonatsrate
			// 
			layoutMonatsrate.ColumnCount = 1;
			layoutMonatsrate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			layoutMonatsrate.Controls.Add(layoutTilgungsrate, 0, 0);
			layoutMonatsrate.Dock = DockStyle.Fill;
			layoutMonatsrate.Location = new Point(3, 263);
			layoutMonatsrate.Name = "layoutMonatsrate";
			layoutMonatsrate.RowCount = 1;
			layoutMonatsrate.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			layoutMonatsrate.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			layoutMonatsrate.Size = new Size(419, 255);
			layoutMonatsrate.TabIndex = 2;
			// 
			// layoutTilgungsrate
			// 
			layoutTilgungsrate.ColumnCount = 2;
			layoutTilgungsrate.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			layoutTilgungsrate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			layoutTilgungsrate.Controls.Add(lbTilgungsrate, 0, 0);
			layoutTilgungsrate.Controls.Add(pmTilgungsrate, 1, 0);
			layoutTilgungsrate.Controls.Add(lbSollzinsbindung, 0, 1);
			layoutTilgungsrate.Controls.Add(pmSollzinsbindung, 1, 1);
			layoutTilgungsrate.Controls.Add(lbSollzins, 0, 2);
			layoutTilgungsrate.Controls.Add(tbSollzins, 1, 2);
			layoutTilgungsrate.Controls.Add(lbMonatsrate, 0, 3);
			layoutTilgungsrate.Controls.Add(tbMonatsrate, 1, 3);
			layoutTilgungsrate.Dock = DockStyle.Fill;
			layoutTilgungsrate.Location = new Point(3, 3);
			layoutTilgungsrate.Name = "layoutTilgungsrate";
			layoutTilgungsrate.RowCount = 4;
			layoutTilgungsrate.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			layoutTilgungsrate.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			layoutTilgungsrate.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			layoutTilgungsrate.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			layoutTilgungsrate.Size = new Size(413, 249);
			layoutTilgungsrate.TabIndex = 0;
			// 
			// lbTilgungsrate
			// 
			lbTilgungsrate.Anchor = AnchorStyles.Right;
			lbTilgungsrate.AutoSize = true;
			lbTilgungsrate.Location = new Point(45, 23);
			lbTilgungsrate.Name = "lbTilgungsrate";
			lbTilgungsrate.Size = new Size(72, 15);
			lbTilgungsrate.TabIndex = 0;
			lbTilgungsrate.Text = "Tilgungsrate";
			lbTilgungsrate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// pmTilgungsrate
			// 
			pmTilgungsrate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			pmTilgungsrate.BorderStyle = BorderStyle.FixedSingle;
			pmTilgungsrate.Location = new Point(120, 13);
			pmTilgungsrate.Margin = new Padding(0);
			pmTilgungsrate.MinimumSize = new Size(0, 30);
			pmTilgungsrate.Name = "pmTilgungsrate";
			pmTilgungsrate.Size = new Size(293, 35);
			pmTilgungsrate.Step = 0.5D;
			pmTilgungsrate.TabIndex = 1;
			pmTilgungsrate.Unit = "";
			// 
			// lbSollzinsbindung
			// 
			lbSollzinsbindung.Anchor = AnchorStyles.Right;
			lbSollzinsbindung.AutoSize = true;
			lbSollzinsbindung.Location = new Point(26, 85);
			lbSollzinsbindung.Name = "lbSollzinsbindung";
			lbSollzinsbindung.Size = new Size(91, 15);
			lbSollzinsbindung.TabIndex = 2;
			lbSollzinsbindung.Text = "Sollzinsbindung";
			lbSollzinsbindung.TextAlign = ContentAlignment.MiddleRight;
			// 
			// pmSollzinsbindung
			// 
			pmSollzinsbindung.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			pmSollzinsbindung.BorderStyle = BorderStyle.FixedSingle;
			pmSollzinsbindung.Location = new Point(120, 75);
			pmSollzinsbindung.Margin = new Padding(0);
			pmSollzinsbindung.MinimumSize = new Size(0, 32);
			pmSollzinsbindung.Name = "pmSollzinsbindung";
			pmSollzinsbindung.Size = new Size(293, 35);
			pmSollzinsbindung.Step = 0.5D;
			pmSollzinsbindung.TabIndex = 3;
			pmSollzinsbindung.Unit = "";
			// 
			// lbSollzins
			// 
			lbSollzins.Anchor = AnchorStyles.Right;
			lbSollzins.AutoSize = true;
			lbSollzins.Location = new Point(71, 147);
			lbSollzins.Name = "lbSollzins";
			lbSollzins.Size = new Size(46, 15);
			lbSollzins.TabIndex = 4;
			lbSollzins.Text = "Sollzins";
			lbSollzins.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbSollzins
			// 
			tbSollzins.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbSollzins.Location = new Point(123, 143);
			tbSollzins.Name = "tbSollzins";
			tbSollzins.Size = new Size(287, 23);
			tbSollzins.TabIndex = 5;
			tbSollzins.TextAlign = HorizontalAlignment.Right;
			// 
			// lbMonatsrate
			// 
			lbMonatsrate.Anchor = AnchorStyles.Right;
			lbMonatsrate.AutoSize = true;
			lbMonatsrate.Location = new Point(50, 210);
			lbMonatsrate.Name = "lbMonatsrate";
			lbMonatsrate.Size = new Size(67, 15);
			lbMonatsrate.TabIndex = 6;
			lbMonatsrate.Text = "Monatsrate";
			lbMonatsrate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbMonatsrate
			// 
			tbMonatsrate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbMonatsrate.Location = new Point(123, 206);
			tbMonatsrate.Name = "tbMonatsrate";
			tbMonatsrate.Size = new Size(287, 23);
			tbMonatsrate.TabIndex = 7;
			tbMonatsrate.TextAlign = HorizontalAlignment.Right;
			// 
			// tilgungsplan
			// 
			tilgungsplan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tilgungsplan.Dock = DockStyle.Fill;
			tilgungsplan.Location = new Point(428, 263);
			tilgungsplan.Name = "tilgungsplan";
			tilgungsplan.Size = new Size(513, 255);
			tilgungsplan.TabIndex = 3;
			// 
			// RechnerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(944, 521);
			Controls.Add(tableLayoutPanelMain);
			MinimumSize = new Size(960, 560);
			Name = "RechnerForm";
			Text = "Baufinanzierungsrechner";
			tableLayoutPanelMain.ResumeLayout(false);
			tableLayoutInfo.ResumeLayout(false);
			tableLayoutInfo.PerformLayout();
			tableLayoutKaufnebenkostenMain.ResumeLayout(false);
			tableLayoutKaufnebenkostenMain.PerformLayout();
			tableLayoutKaufnebenkosten.ResumeLayout(false);
			tableLayoutKaufnebenkosten.PerformLayout();
			layoutMonatsrate.ResumeLayout(false);
			layoutTilgungsrate.ResumeLayout(false);
			layoutTilgungsrate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tilgungsplan).EndInit();
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
		private TableLayoutPanel layoutMonatsrate;
		private TableLayoutPanel layoutTilgungsrate;
		private Label lbTilgungsrate;
		private UserControl.PlusMinusControl pmTilgungsrate;
		private Label lbSollzinsbindung;
		private UserControl.PlusMinusControl pmSollzinsbindung;
		private Label lbSollzins;
		private TextBox tbSollzins;
		private Label lbMonatsrate;
		private TextBox tbMonatsrate;
		private DataGridView tilgungsplan;

		public TextBox TbKaufpreis { get => tbKaufpreis; }
		public TextBox TbEigenkapital { get => tbEigenkapital; }
		public Label LbGrunderwerbssteuerWert { get => lbGrunderwerbssteuerWert; }
		public Label LbNotarkostenWert { get => lbNotarkostenWert; }
		public Label LbGrundbucheintragWert { get => lbGrundbucheintragWert; }
		public Label LbMaklerprovisionWert { get => lbMaklerprovisionWert; }
		public Label LbKaufnebenkostensummeWert { get => lbKaufnebenkostensummeWert; }
		public TextBox TbGrunderwerbssteuerProzent { get => tbGrunderwerbssteuerProzent; }
		public TextBox TbNotarkostenProzent { get => tbNotarkostenProzent; }
		public TextBox TbGrundbucheintragProzent { get => tbGrundbucheintragProzent; }
		public TextBox TbMaklerprovisionProzent { get => tbMaklerprovisionProzent; }
		public Label LbKaufnebekostenWertInfo { get => lbKaufnebekostenWertInfo; }
		public Label LbNettoDarlehenWert { get => lbNettoDarlehenWert; }
		public Label LbTilgungsrate { get => lbTilgungsrate; }
		public PlusMinusControl PmTilgungsrate { get => pmTilgungsrate; }
		public PlusMinusControl PmSollzinsbindung { get => pmSollzinsbindung; }
		public TextBox TbSollzins { get => tbSollzins; }
		public TextBox TbMonatsrate { get => tbMonatsrate; }
		public DataGridView Tilgungsplan { get => tilgungsplan; }
	}
}