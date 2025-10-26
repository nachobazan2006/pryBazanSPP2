namespace pryBazanSPP2
{
    public partial class frmBoleteria : Form
    {
        public frmBoleteria()
        {
            InitializeComponent();
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
        public struct Datos
        {
            public int Distancia;
            public int Dias;
            public int DistanciaTotal;
            public int PrecioTotal;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int precioPorKm = 5;

            // Obtener los valores de los NumericUpDown
            float Distancia = (float)NupDistancia.Value;
            int Dias = (int)NupDias.Value;

            // Calculoo la distancia total (ida y vuelta)
            float DistanciaTotal = Distancia * 2;

            // Calculo el precio total
            float precioTotal = DistanciaTotal * precioPorKm;

            if (Distancia >= 100 && Dias >= 7)
            {
                precioTotal = precioTotal / 2;


            }
            lstResultado.Items.Add("El precio total del pasaje es: $" + precioTotal.ToString("0.00"));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NupDias.Value = 1;
            NupDistancia.Value = 1;
            lstResultado.Items.Clear();
        }
    }
}
