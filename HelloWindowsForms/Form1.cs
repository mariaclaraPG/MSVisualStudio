namespace HelloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC Calculado: {imc:F2}";

            if (imc >= 18.5 && imc <= 24.9)
            {
                interpretacao.Text = "Peso normal";
            }
            else if (imc < 18.5)
            {
                interpretacao.Text = "Abaixo do peso";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                interpretacao.Text = "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                interpretacao.Text = "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                interpretacao.Text = "Obesidade grau II";
            }
            else
            {
                interpretacao.Text = "Obesidade grau III ou mais";
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}