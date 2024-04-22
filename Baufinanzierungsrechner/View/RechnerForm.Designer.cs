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
			tableLayoutKaufpreisEigenkapital = new TableLayoutPanel();
			lbKaufpreis = new Label();
			tbKaufpreis = new TextBox();
			lblEigenkapital = new Label();
			tbEigenkapital = new TextBox();
			tableLayoutKaufnebenkostenMain = new TableLayoutPanel();
			lblKaufnebenkosten = new Label();
			tableLayoutKaufnebenkosten = new TableLayoutPanel();
			lblGrunderwebssteuer = new Label();
			lblNotarkosten = new Label();
			lblGrundbucheintrag = new Label();
			lblMaklerprovision = new Label();
			tbGrunderwerbssteuer = new TextBox();
			tbNotarkosten = new TextBox();
			tbGrundbucheintrag = new TextBox();
			tbMaklerprovision = new TextBox();
			flowLayoutGrunderwerbsteuer = new FlowLayoutPanel();
			lbGrunderwerbssteuerProzent = new Label();
			tbGrunderwerbssteuerProzent = new TextBox();
			layoutNotarkosten = new FlowLayoutPanel();
			lbNotarkostenProzent = new Label();
			textBox1 = new TextBox();
			tableLayoutPanelMain.SuspendLayout();
			tableLayoutKaufpreisEigenkapital.SuspendLayout();
			tableLayoutKaufnebenkostenMain.SuspendLayout();
			tableLayoutKaufnebenkosten.SuspendLayout();
			flowLayoutGrunderwerbsteuer.SuspendLayout();
			layoutNotarkosten.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			tableLayoutPanelMain.ColumnCount = 2;
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
			tableLayoutPanelMain.Controls.Add(tableLayoutKaufpreisEigenkapital, 0, 0);
			tableLayoutPanelMain.Controls.Add(tableLayoutKaufnebenkostenMain, 1, 0);
			tableLayoutPanelMain.Dock = DockStyle.Fill;
			tableLayoutPanelMain.Location = new Point(0, 0);
			tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			tableLayoutPanelMain.RowCount = 2;
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Size = new Size(844, 468);
			tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutKaufpreisEigenkapital
			// 
			tableLayoutKaufpreisEigenkapital.ColumnCount = 2;
			tableLayoutKaufpreisEigenkapital.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutKaufpreisEigenkapital.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutKaufpreisEigenkapital.Controls.Add(lbKaufpreis, 0, 0);
			tableLayoutKaufpreisEigenkapital.Controls.Add(tbKaufpreis, 1, 0);
			tableLayoutKaufpreisEigenkapital.Controls.Add(lblEigenkapital, 0, 1);
			tableLayoutKaufpreisEigenkapital.Controls.Add(tbEigenkapital, 1, 1);
			tableLayoutKaufpreisEigenkapital.Dock = DockStyle.Fill;
			tableLayoutKaufpreisEigenkapital.Location = new Point(3, 3);
			tableLayoutKaufpreisEigenkapital.Name = "tableLayoutKaufpreisEigenkapital";
			tableLayoutKaufpreisEigenkapital.RowCount = 2;
			tableLayoutKaufpreisEigenkapital.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutKaufpreisEigenkapital.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutKaufpreisEigenkapital.Size = new Size(419, 228);
			tableLayoutKaufpreisEigenkapital.TabIndex = 0;
			// 
			// lbKaufpreis
			// 
			lbKaufpreis.Anchor = AnchorStyles.Right;
			lbKaufpreis.AutoSize = true;
			lbKaufpreis.Location = new Point(66, 49);
			lbKaufpreis.Name = "lbKaufpreis";
			lbKaufpreis.Size = new Size(56, 15);
			lbKaufpreis.TabIndex = 0;
			lbKaufpreis.Text = "Kaufpreis";
			lbKaufpreis.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbKaufpreis
			// 
			tbKaufpreis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbKaufpreis.Location = new Point(128, 45);
			tbKaufpreis.Name = "tbKaufpreis";
			tbKaufpreis.Size = new Size(288, 23);
			tbKaufpreis.TabIndex = 1;
			// 
			// lblEigenkapital
			// 
			lblEigenkapital.Anchor = AnchorStyles.Right;
			lblEigenkapital.AutoSize = true;
			lblEigenkapital.Location = new Point(51, 163);
			lblEigenkapital.Name = "lblEigenkapital";
			lblEigenkapital.Size = new Size(71, 15);
			lblEigenkapital.TabIndex = 2;
			lblEigenkapital.Text = "Eigenkapital";
			lblEigenkapital.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbEigenkapital
			// 
			tbEigenkapital.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbEigenkapital.Location = new Point(128, 159);
			tbEigenkapital.Name = "tbEigenkapital";
			tbEigenkapital.Size = new Size(288, 23);
			tbEigenkapital.TabIndex = 3;
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
			tableLayoutKaufnebenkostenMain.Size = new Size(419, 228);
			tableLayoutKaufnebenkostenMain.TabIndex = 1;
			// 
			// lblKaufnebenkosten
			// 
			lblKaufnebenkosten.AutoSize = true;
			lblKaufnebenkosten.Dock = DockStyle.Fill;
			lblKaufnebenkosten.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblKaufnebenkosten.Location = new Point(3, 0);
			lblKaufnebenkosten.Name = "lblKaufnebenkosten";
			lblKaufnebenkosten.Size = new Size(413, 40);
			lblKaufnebenkosten.TabIndex = 0;
			lblKaufnebenkosten.Text = "Kaufnebenkosten";
			lblKaufnebenkosten.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutKaufnebenkosten
			// 
			tableLayoutKaufnebenkosten.ColumnCount = 3;
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.62228F));
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8539F));
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.523819F));
			tableLayoutKaufnebenkosten.Controls.Add(lblGrunderwebssteuer, 0, 0);
			tableLayoutKaufnebenkosten.Controls.Add(lblNotarkosten, 0, 1);
			tableLayoutKaufnebenkosten.Controls.Add(lblGrundbucheintrag, 0, 2);
			tableLayoutKaufnebenkosten.Controls.Add(lblMaklerprovision, 0, 3);
			tableLayoutKaufnebenkosten.Controls.Add(tbGrunderwerbssteuer, 1, 0);
			tableLayoutKaufnebenkosten.Controls.Add(tbNotarkosten, 1, 1);
			tableLayoutKaufnebenkosten.Controls.Add(tbGrundbucheintrag, 1, 2);
			tableLayoutKaufnebenkosten.Controls.Add(tbMaklerprovision, 1, 3);
			tableLayoutKaufnebenkosten.Controls.Add(flowLayoutGrunderwerbsteuer, 2, 0);
			tableLayoutKaufnebenkosten.Controls.Add(layoutNotarkosten, 2, 1);
			tableLayoutKaufnebenkosten.Dock = DockStyle.Fill;
			tableLayoutKaufnebenkosten.Location = new Point(3, 43);
			tableLayoutKaufnebenkosten.Name = "tableLayoutKaufnebenkosten";
			tableLayoutKaufnebenkosten.RowCount = 4;
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.Size = new Size(413, 142);
			tableLayoutKaufnebenkosten.TabIndex = 1;
			// 
			// lblGrunderwebssteuer
			// 
			lblGrunderwebssteuer.Anchor = AnchorStyles.Right;
			lblGrunderwebssteuer.AutoSize = true;
			lblGrunderwebssteuer.Location = new Point(14, 10);
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
			lblNotarkosten.Location = new Point(55, 45);
			lblNotarkosten.Name = "lblNotarkosten";
			lblNotarkosten.Size = new Size(72, 15);
			lblNotarkosten.TabIndex = 1;
			lblNotarkosten.Text = "Notarkosten";
			// 
			// lblGrundbucheintrag
			// 
			lblGrundbucheintrag.Anchor = AnchorStyles.Right;
			lblGrundbucheintrag.AutoSize = true;
			lblGrundbucheintrag.Location = new Point(23, 80);
			lblGrundbucheintrag.Name = "lblGrundbucheintrag";
			lblGrundbucheintrag.Size = new Size(104, 15);
			lblGrundbucheintrag.TabIndex = 2;
			lblGrundbucheintrag.Text = "Grundbucheintrag";
			// 
			// lblMaklerprovision
			// 
			lblMaklerprovision.Anchor = AnchorStyles.Right;
			lblMaklerprovision.AutoSize = true;
			lblMaklerprovision.Location = new Point(35, 116);
			lblMaklerprovision.Name = "lblMaklerprovision";
			lblMaklerprovision.Size = new Size(92, 15);
			lblMaklerprovision.TabIndex = 3;
			lblMaklerprovision.Text = "Maklerprovision";
			// 
			// tbGrunderwerbssteuer
			// 
			tbGrunderwerbssteuer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbGrunderwerbssteuer.Location = new Point(133, 6);
			tbGrunderwerbssteuer.Name = "tbGrunderwerbssteuer";
			tbGrunderwerbssteuer.ReadOnly = true;
			tbGrunderwerbssteuer.Size = new Size(183, 23);
			tbGrunderwerbssteuer.TabIndex = 4;
			tbGrunderwerbssteuer.TextAlign = HorizontalAlignment.Right;
			// 
			// tbNotarkosten
			// 
			tbNotarkosten.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbNotarkosten.Location = new Point(133, 41);
			tbNotarkosten.Name = "tbNotarkosten";
			tbNotarkosten.ReadOnly = true;
			tbNotarkosten.Size = new Size(183, 23);
			tbNotarkosten.TabIndex = 5;
			tbNotarkosten.TextAlign = HorizontalAlignment.Right;
			// 
			// tbGrundbucheintrag
			// 
			tbGrundbucheintrag.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbGrundbucheintrag.Location = new Point(133, 76);
			tbGrundbucheintrag.Name = "tbGrundbucheintrag";
			tbGrundbucheintrag.ReadOnly = true;
			tbGrundbucheintrag.Size = new Size(183, 23);
			tbGrundbucheintrag.TabIndex = 6;
			tbGrundbucheintrag.TextAlign = HorizontalAlignment.Right;
			// 
			// tbMaklerprovision
			// 
			tbMaklerprovision.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbMaklerprovision.Location = new Point(133, 112);
			tbMaklerprovision.Name = "tbMaklerprovision";
			tbMaklerprovision.ReadOnly = true;
			tbMaklerprovision.Size = new Size(183, 23);
			tbMaklerprovision.TabIndex = 7;
			tbMaklerprovision.TextAlign = HorizontalAlignment.Right;
			// 
			// flowLayoutGrunderwerbsteuer
			// 
			flowLayoutGrunderwerbsteuer.Controls.Add(lbGrunderwerbssteuerProzent);
			flowLayoutGrunderwerbsteuer.Controls.Add(tbGrunderwerbssteuerProzent);
			flowLayoutGrunderwerbsteuer.Dock = DockStyle.Fill;
			flowLayoutGrunderwerbsteuer.Location = new Point(322, 3);
			flowLayoutGrunderwerbsteuer.Name = "flowLayoutGrunderwerbsteuer";
			flowLayoutGrunderwerbsteuer.RightToLeft = RightToLeft.Yes;
			flowLayoutGrunderwerbsteuer.Size = new Size(88, 29);
			flowLayoutGrunderwerbsteuer.TabIndex = 8;
			// 
			// lbGrunderwerbssteuerProzent
			// 
			lbGrunderwerbssteuerProzent.Anchor = AnchorStyles.Right;
			lbGrunderwerbssteuerProzent.Location = new Point(67, 0);
			lbGrunderwerbssteuerProzent.MaximumSize = new Size(18, 23);
			lbGrunderwerbssteuerProzent.MinimumSize = new Size(18, 23);
			lbGrunderwerbssteuerProzent.Name = "lbGrunderwerbssteuerProzent";
			lbGrunderwerbssteuerProzent.Size = new Size(18, 23);
			lbGrunderwerbssteuerProzent.TabIndex = 0;
			lbGrunderwerbssteuerProzent.Text = "%";
			lbGrunderwerbssteuerProzent.TextAlign = ContentAlignment.BottomCenter;
			// 
			// tbGrunderwerbssteuerProzent
			// 
			tbGrunderwerbssteuerProzent.Dock = DockStyle.Fill;
			tbGrunderwerbssteuerProzent.Location = new Point(8, 3);
			tbGrunderwerbssteuerProzent.Name = "tbGrunderwerbssteuerProzent";
			tbGrunderwerbssteuerProzent.Size = new Size(53, 23);
			tbGrunderwerbssteuerProzent.TabIndex = 1;
			// 
			// layoutNotarkosten
			// 
			layoutNotarkosten.Controls.Add(lbNotarkostenProzent);
			layoutNotarkosten.Controls.Add(textBox1);
			layoutNotarkosten.Dock = DockStyle.Fill;
			layoutNotarkosten.Location = new Point(322, 38);
			layoutNotarkosten.Name = "layoutNotarkosten";
			layoutNotarkosten.RightToLeft = RightToLeft.Yes;
			layoutNotarkosten.Size = new Size(88, 29);
			layoutNotarkosten.TabIndex = 9;
			// 
			// lbNotarkostenProzent
			// 
			lbNotarkostenProzent.Anchor = AnchorStyles.Right;
			lbNotarkostenProzent.Location = new Point(67, 0);
			lbNotarkostenProzent.MaximumSize = new Size(18, 23);
			lbNotarkostenProzent.MinimumSize = new Size(18, 23);
			lbNotarkostenProzent.Name = "lbNotarkostenProzent";
			lbNotarkostenProzent.Size = new Size(18, 23);
			lbNotarkostenProzent.TabIndex = 0;
			lbNotarkostenProzent.Text = "%";
			lbNotarkostenProzent.TextAlign = ContentAlignment.BottomCenter;
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(8, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(53, 23);
			textBox1.TabIndex = 1;
			// 
			// RechnerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(844, 468);
			Controls.Add(tableLayoutPanelMain);
			MinimumSize = new Size(860, 0);
			Name = "RechnerForm";
			Text = "Baufinanzierungsrechner";
			tableLayoutPanelMain.ResumeLayout(false);
			tableLayoutKaufpreisEigenkapital.ResumeLayout(false);
			tableLayoutKaufpreisEigenkapital.PerformLayout();
			tableLayoutKaufnebenkostenMain.ResumeLayout(false);
			tableLayoutKaufnebenkostenMain.PerformLayout();
			tableLayoutKaufnebenkosten.ResumeLayout(false);
			tableLayoutKaufnebenkosten.PerformLayout();
			flowLayoutGrunderwerbsteuer.ResumeLayout(false);
			flowLayoutGrunderwerbsteuer.PerformLayout();
			layoutNotarkosten.ResumeLayout(false);
			layoutNotarkosten.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutKaufpreisEigenkapital;
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
		private TextBox tbGrunderwerbssteuer;
		private TextBox tbNotarkosten;
		private TextBox tbGrundbucheintrag;
		private TextBox tbMaklerprovision;
		private FlowLayoutPanel flowLayoutGrunderwerbsteuer;
		private Label lbGrunderwerbssteuerProzent;
		private TextBox tbGrunderwerbssteuerProzent;
		private FlowLayoutPanel layoutNotarkosten;
		private Label lbNotarkostenProzent;
		private TextBox textBox1;
	}
}