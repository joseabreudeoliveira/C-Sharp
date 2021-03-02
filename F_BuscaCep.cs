using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Correios.Net;  //NuGet CORREIO


namespace Componentes
{
    public partial class F_BuscaCep : Form
    {
        public F_BuscaCep()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mtbCep.Text);
                    txtEnd.Text = resultado.end;
                    txtCidade.Text = resultado.cidade;
                    txtEstado.Text = resultado.uf;
                    txtBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtbCep.Text = "";
            txtEnd.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtBairro.Text = "";
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
