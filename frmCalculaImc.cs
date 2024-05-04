using System.Diagnostics.Eventing.Reader;

namespace ImcApp
{
    public partial class frmCalculaImc : Form
    {
        public frmCalculaImc()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Pegando o valor do PESO digitado pelo usuario, e guardando na variavel
            decimal peso = numPeso.Value;

            //Pegando o valor da ALTURA digitado pelo usuario, e guardando na variavel
            decimal altura = numAltura.Value;

            //Calcula o IMC
            decimal imc = peso / (altura * altura);

            //Mostra o resultado do calculo IMC
            lblResultado.Text = imc.ToString("N2");

            if (imc <= 18.5m)
            {
                seta.Location = new Point(357, 392);
            }
            if (imc > 18.5m && imc <= 24.9m)
            {
                seta.Location = new Point(461, 392);
            }
            if (imc > 24.9m && imc <= 29.9m)
            {
                seta.Location = new Point(561, 392);
            }
            if (imc > 30 && imc <= 34)
            {
                seta.Location = new Point(663, 392);
            }
            if (imc > 35)
            {
                seta.Location = new Point(767, 392);
            }
        }


    }
}
