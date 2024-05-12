namespace Baufinanzierungsrechner.View.UserControl {
	partial class PlusMinusControl {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			tableLayoutPanel1 = new TableLayoutPanel();
			btnMinus = new Button();
			btnPlus = new Button();
			lbNumber = new Label();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Controls.Add(btnMinus, 0, 0);
			tableLayoutPanel1.Controls.Add(btnPlus, 2, 0);
			tableLayoutPanel1.Controls.Add(lbNumber, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.MinimumSize = new Size(0, 32);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(148, 32);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// btnMinus
			// 
			btnMinus.Dock = DockStyle.Fill;
			btnMinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnMinus.Location = new Point(0, 0);
			btnMinus.Margin = new Padding(0);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new Size(37, 32);
			btnMinus.TabIndex = 0;
			btnMinus.Text = "-";
			btnMinus.UseVisualStyleBackColor = true;
			// 
			// btnPlus
			// 
			btnPlus.Dock = DockStyle.Fill;
			btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnPlus.Location = new Point(111, 0);
			btnPlus.Margin = new Padding(0);
			btnPlus.Name = "btnPlus";
			btnPlus.Size = new Size(37, 32);
			btnPlus.TabIndex = 1;
			btnPlus.Text = "+";
			btnPlus.UseVisualStyleBackColor = true;
			// 
			// lbNumber
			// 
			lbNumber.AutoSize = true;
			lbNumber.BackColor = Color.White;
			lbNumber.BorderStyle = BorderStyle.FixedSingle;
			lbNumber.Dock = DockStyle.Fill;
			lbNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbNumber.Location = new Point(37, 0);
			lbNumber.Margin = new Padding(0);
			lbNumber.MinimumSize = new Size(0, 32);
			lbNumber.Name = "lbNumber";
			lbNumber.Size = new Size(74, 32);
			lbNumber.TabIndex = 2;
			lbNumber.Text = "1";
			lbNumber.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// PlusMinusControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(0);
			MinimumSize = new Size(0, 32);
			Name = "PlusMinusControl";
			Size = new Size(148, 32);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Button btnMinus;
		private Button btnPlus;
		private Label lbNumber;
	}
}
