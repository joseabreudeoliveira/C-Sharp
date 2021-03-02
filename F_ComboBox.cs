using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            // object carro = "Carro";
            //cb_transportes.Items.Add(carro);

            //ou

            //cb_transportes.Items.Add("Carro");
            //cb_transportes.Items.Add("Avião");
            //cb_transportes.Items.Add("Navio");
            //cb_transportes.Items.Add("Ónibus");
            //cb_transportes.Items.Add("Trem");

            //ou

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ónibus");
            tr.Add("Trem");

            cb_transportes.Items.AddRange(tr.ToArray());
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void btn_adicionarNovoTransprote_Click(object sender, EventArgs e)
        {
            //Verifica se esta preenchido
            if(tb_transporte.Text != "") {
                //Verifica se já existe.Se encotrar retorna 1(verdadeiro) senão -1(falso)
                if (cb_transportes.FindString(tb_transporte.Text) < 0) {
                    cb_transportes.Items.Add(tb_transporte.Text);
                    tb_transporte.Clear();
                }
            }
        }
    }
}
