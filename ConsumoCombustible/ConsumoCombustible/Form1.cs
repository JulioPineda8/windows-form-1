namespace ConsumoCombustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Kilometros = double.Parse(txtDistancia.Text);
            double rendimiento = double.Parse(txtConsumo.Text);



            double Galonesconsumidos = Kilometros / rendimiento * 1;

            txtGalones.Text = Galonesconsumidos.ToString();
        }
    }
}
