namespace ConversorUnidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbConversion.Items.Add("Kilómetros a Millas");
            cmbConversion.Items.Add("Millas a Kilómetros");
            cmbConversion.Items.Add("Celsius a Fahrenheit");
            cmbConversion.Items.Add("Fahrenheit a Celsius");

            cmbConversion.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;

            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            double resultado = 0;

            switch (cmbConversion.SelectedItem.ToString())
            {
                case "Kilómetros a Millas":
                    resultado = valor * 0.621371;
                    break;

                case "Millas a Kilómetros":
                    resultado = valor * 1.60934;
                    break;

                case "Celsius a Fahrenheit":
                    resultado = (valor * 9 / 5) + 32;
                    break;

                case "Fahrenheit a Celsius":
                    resultado = (valor - 32) * 5 / 9;
                    break;
            }

            lblResultado.Text = "Resultado: " + resultado.ToString("0.00");
        }
    }
}