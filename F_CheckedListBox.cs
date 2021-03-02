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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            //Reetorna toda a lista
            //txt = clb_transportes.Items[0].ToString();  
            //Reetorna a lista dos selecionados
            //clb_transportes.CheckedItems[0].ToString(); 

            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            // object carro = "Carro";
            //clb_transportes.Items.Add(carro, true);

            //ou
            
            //clb_transportes.Items.Add("Carro", false);
            //clb_transportes.Items.Add("Avião", false);
            //clb_transportes.Items.Add("Navio", false);
            //clb_transportes.Items.Add("Ónibus", false);
            //clb_transportes.Items.Add("Trem", false);
            
            //ou
            
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ónibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_NovoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_NovoTransporte.Text, false);
                tb_NovoTransporte.Clear();
                tb_NovoTransporte.Focus();
            }
        }
    }
}
