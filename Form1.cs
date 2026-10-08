using System.Data;
using Oracle.ManagedDataAccess.Client;
using CalculadoraOracle19C.Data;    


namespace CalculadoraOracle19C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  lblResultado.Text = "Resultado: 0";
        }

        private bool ObtenerNumeros(out decimal numero1, out decimal numero2)
        {
            numero1 = 0;
            numero2 = 0;    

            if (!decimal.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Ingrese un numero valido en NUMERO 1",
                                "DATO INVALIDO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtNumero1.Focus();
                return false;
            }

            if (!decimal.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Ingrese un numero valido en NUMERO 2",
                                "DATO INVALIDO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNumero2.Focus();
                return false;
            }

            return true;
        }   
    }
}
