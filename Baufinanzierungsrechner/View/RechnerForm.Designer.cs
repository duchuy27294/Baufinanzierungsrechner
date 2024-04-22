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
			tableLayoutPanelMain.SuspendLayout();
			tableLayoutKaufpreisEigenkapital.SuspendLayout();
			tableLayoutKaufnebenkostenMain.SuspendLayout();
			tableLayoutKaufnebenkosten.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			tableLayoutPanelMain.ColumnCount = 2;
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Controls.Add(tableLayoutKaufpreisEigenkapital, 0, 0);
			tableLayoutPanelMain.Controls.Add(tableLayoutKaufnebenkostenMain, 1, 0);
			tableLayoutPanelMain.Dock = DockStyle.Fill;
			tableLayoutPanelMain.Location = new Point(0, 0);
			tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			tableLayoutPanelMain.RowCount = 2;
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Size = new Size(954, 441);
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
			tableLayoutKaufpreisEigenkapital.Size = new Size(471, 214);
			tableLayoutKaufpreisEigenkapital.TabIndex = 0;
			// 
			// lbKaufpreis
			// 
			lbKaufpreis.Anchor = AnchorStyles.Right;
			lbKaufpreis.AutoSize = true;
			lbKaufpreis.Location = new Point(82, 46);
			lbKaufpreis.Name = "lbKaufpreis";
			lbKaufpreis.Size = new Size(56, 15);
			lbKaufpreis.TabIndex = 0;
			lbKaufpreis.Text = "Kaufpreis";
			lbKaufpreis.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbKaufpreis
			// 
			tbKaufpreis.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbKaufpreis.Location = new Point(144, 42);
			tbKaufpreis.Name = "tbKaufpreis";
			tbKaufpreis.Size = new Size(324, 23);
			tbKaufpreis.TabIndex = 1;
			// 
			// lblEigenkapital
			// 
			lblEigenkapital.Anchor = AnchorStyles.Right;
			lblEigenkapital.AutoSize = true;
			lblEigenkapital.Location = new Point(67, 153);
			lblEigenkapital.Name = "lblEigenkapital";
			lblEigenkapital.Size = new Size(71, 15);
			lblEigenkapital.TabIndex = 2;
			lblEigenkapital.Text = "Eigenkapital";
			lblEigenkapital.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tbEigenkapital
			// 
			tbEigenkapital.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbEigenkapital.Location = new Point(144, 149);
			tbEigenkapital.Name = "tbEigenkapital";
			tbEigenkapital.Size = new Size(324, 23);
			tbEigenkapital.TabIndex = 3;
			// 
			// tableLayoutKaufnebenkostenMain
			// 
			tableLayoutKaufnebenkostenMain.ColumnCount = 1;
			tableLayoutKaufnebenkostenMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutKaufnebenkostenMain.Controls.Add(lblKaufnebenkosten, 0, 0);
			tableLayoutKaufnebenkostenMain.Controls.Add(tableLayoutKaufnebenkosten, 0, 1);
			tableLayoutKaufnebenkostenMain.Dock = DockStyle.Fill;
			tableLayoutKaufnebenkostenMain.Location = new Point(480, 3);
			tableLayoutKaufnebenkostenMain.Name = "tableLayoutKaufnebenkostenMain";
			tableLayoutKaufnebenkostenMain.RowCount = 3;
			tableLayoutKaufnebenkostenMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkostenMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutKaufnebenkostenMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutKaufnebenkostenMain.Size = new Size(471, 214);
			tableLayoutKaufnebenkostenMain.TabIndex = 1;
			// 
			// lblKaufnebenkosten
			// 
			lblKaufnebenkosten.AutoSize = true;
			lblKaufnebenkosten.Dock = DockStyle.Fill;
			lblKaufnebenkosten.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblKaufnebenkosten.Location = new Point(3, 0);
			lblKaufnebenkosten.Name = "lblKaufnebenkosten";
			lblKaufnebenkosten.Size = new Size(465, 40);
			lblKaufnebenkosten.TabIndex = 0;
			lblKaufnebenkosten.Text = "Kaufnebenkosten";
			lblKaufnebenkosten.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutKaufnebenkosten
			// 
			tableLayoutKaufnebenkosten.ColumnCount = 3;
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0789719F));
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.71592F));
			tableLayoutKaufnebenkosten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2051048F));
			tableLayoutKaufnebenkosten.Controls.Add(lblGrunderwebssteuer, 0, 0);
			tableLayoutKaufnebenkosten.Controls.Add(lblNotarkosten, 0, 1);
			tableLayoutKaufnebenkosten.Controls.Add(lblGrundbucheintrag, 0, 2);
			tableLayoutKaufnebenkosten.Controls.Add(lblMaklerprovision, 0, 3);
			tableLayoutKaufnebenkosten.Controls.Add(tbGrunderwerbssteuer, 1, 0);
			tableLayoutKaufnebenkosten.Controls.Add(tbNotarkosten, 1, 1);
			tableLayoutKaufnebenkosten.Controls.Add(tbGrundbucheintrag, 1, 2);
			tableLayoutKaufnebenkosten.Controls.Add(tbMaklerprovision, 1, 3);
			tableLayoutKaufnebenkosten.Dock = DockStyle.Fill;
			tableLayoutKaufnebenkosten.Location = new Point(3, 43);
			tableLayoutKaufnebenkosten.Name = "tableLayoutKaufnebenkosten";
			tableLayoutKaufnebenkosten.RowCount = 4;
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutKaufnebenkosten.Size = new Size(465, 128);
			tableLayoutKaufnebenkosten.TabIndex = 1;
			// 
			// lblGrunderwebssteuer
			// 
			lblGrunderwebssteuer.Anchor = AnchorStyles.Right;
			lblGrunderwebssteuer.AutoSize = true;
			lblGrunderwebssteuer.Location = new Point(14, 8);
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
			lblNotarkosten.Location = new Point(55, 40);
			lblNotarkosten.Name = "lblNotarkosten";
			lblNotarkosten.Size = new Size(72, 15);
			lblNotarkosten.TabIndex = 1;
			lblNotarkosten.Text = "Notarkosten";
			// 
			// lblGrundbucheintrag
			// 
			lblGrundbucheintrag.Anchor = AnchorStyles.Right;
			lblGrundbucheintrag.AutoSize = true;
			lblGrundbucheintrag.Location = new Point(23, 72);
			lblGrundbucheintrag.Name = "lblGrundbucheintrag";
			lblGrundbucheintrag.Size = new Size(104, 15);
			lblGrundbucheintrag.TabIndex = 2;
			lblGrundbucheintrag.Text = "Grundbucheintrag";
			// 
			// lblMaklerprovision
			// 
			lblMaklerprovision.Anchor = AnchorStyles.Right;
			lblMaklerprovision.AutoSize = true;
			lblMaklerprovision.Location = new Point(35, 104);
			lblMaklerprovision.Name = "lblMaklerprovision";
			lblMaklerprovision.Size = new Size(92, 15);
			lblMaklerprovision.TabIndex = 3;
			lblMaklerprovision.Text = "Maklerprovision";
			// 
			// tbGrunderwerbssteuer
			// 
			tbGrunderwerbssteuer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbGrunderwerbssteuer.Location = new Point(133, 4);
			tbGrunderwerbssteuer.Name = "tbGrunderwerbssteuer";
			tbGrunderwerbssteuer.ReadOnly = true;
			tbGrunderwerbssteuer.Size = new Size(183, 23);
			tbGrunderwerbssteuer.TabIndex = 4;
			tbGrunderwerbssteuer.TextAlign = HorizontalAlignment.Right;
			// 
			// tbNotarkosten
			// 
			tbNotarkosten.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbNotarkosten.Location = new Point(133, 36);
			tbNotarkosten.Name = "tbNotarkosten";
			tbNotarkosten.ReadOnly = true;
			tbNotarkosten.Size = new Size(183, 23);
			tbNotarkosten.TabIndex = 5;
			tbNotarkosten.TextAlign = HorizontalAlignment.Right;
			// 
			// tbGrundbucheintrag
			// 
			tbGrundbucheintrag.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbGrundbucheintrag.Location = new Point(133, 68);
			tbGrundbucheintrag.Name = "tbGrundbucheintrag";
			tbGrundbucheintrag.ReadOnly = true;
			tbGrundbucheintrag.Size = new Size(183, 23);
			tbGrundbucheintrag.TabIndex = 6;
			tbGrundbucheintrag.TextAlign = HorizontalAlignment.Right;
			// 
			// tbMaklerprovision
			// 
			tbMaklerprovision.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbMaklerprovision.Location = new Point(133, 100);
			tbMaklerprovision.Name = "tbMaklerprovision";
			tbMaklerprovision.ReadOnly = true;
			tbMaklerprovision.Size = new Size(183, 23);
			tbMaklerprovision.TabIndex = 7;
			tbMaklerprovision.TextAlign = HorizontalAlignment.Right;
			// 
			// RechnerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(954, 441);
			Controls.Add(tableLayoutPanelMain);
			Name = "RechnerForm";
			Text = "Baufinanzierungsrechner";
			tableLayoutPanelMain.ResumeLayout(false);
			tableLayoutKaufpreisEigenkapital.ResumeLayout(false);
			tableLayoutKaufpreisEigenkapital.PerformLayout();
			tableLayoutKaufnebenkostenMain.ResumeLayout(false);
			tableLayoutKaufnebenkostenMain.PerformLayout();
			tableLayoutKaufnebenkosten.ResumeLayout(false);
			tableLayoutKaufnebenkosten.PerformLayout();
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
	}
}