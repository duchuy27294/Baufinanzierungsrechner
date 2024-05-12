namespace Baufinanzierungsrechner.View.UserControl {
	public partial class PlusMinusControl : System.Windows.Forms.UserControl {
		public event EventHandler<double>? NumberChanged;
		public event EventHandler<string>? UnitChanged;
		private double step;
		private string unit;

		public PlusMinusControl() {
			InitializeComponent();
			this.step = 0.5;
			this.unit = "";
			this.btnMinus.Click += this.Decrease;
			this.btnPlus.Click += this.Increase;
		}

		public double Step {
			get => this.step;
			set => this.step = value;
		}

		public double Number {
			get {
				return Convert.ToDouble(lbNumber.Text.Remove(lbNumber.Text.Length - 2));
			}
			set {
				lbNumber.Text = value.ToString();
				if (!this.unit.Equals(String.Empty)) this.lbNumber.Text += " " + this.unit;
			}
		}

		public string Unit {
			get => this.unit;
			set {
				this.unit = value;
				UnitChanged?.Invoke(this, this.unit);
			}
		}

		private void Decrease(object? sender, EventArgs eventArgs) {
			double number = Convert.ToDouble(lbNumber.Text.Remove(lbNumber.Text.Length - 2));
			double newNumber = number - step;
			this.lbNumber.Text = newNumber.ToString();
			if (!this.unit.Equals(String.Empty)) this.lbNumber.Text += " " + this.unit;
			NumberChanged?.Invoke(this,newNumber);
		}

		private void Increase(object? sender, EventArgs eventArgs) {
			double number = Convert.ToDouble(lbNumber.Text.Remove(lbNumber.Text.Length - 2));
			double newNumber = number + step;
			this.lbNumber.Text = newNumber.ToString();
			if (!this.unit.Equals(String.Empty)) this.lbNumber.Text += " " + this.unit;
			NumberChanged?.Invoke(this, newNumber);
		}

	}
}
