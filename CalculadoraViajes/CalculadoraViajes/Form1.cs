namespace CalculadoraViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Vo = double.Parse(txtOrigen.Text);
            double Vf = double.Parse(txtDestino.Text);
            double velocidad = double.Parse(txtVelocidad.Text);
            double tiempo = Vf - Vo;
            double resuladofinal = tiempo / velocidad;
            txtResultado.Text = resuladofinal.ToString();
            MessageBox.Show("Tiempo estimado de viaje: " + resuladofinal.ToString("0.00") + " horas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
