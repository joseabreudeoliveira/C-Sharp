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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp=new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_Carro);
            transp.Add(cb_Aviao);
            transp.Add(cb_Navio);
            transp.Add(cb_Onibus);
        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            /*
            if (cb_Carro.Checked)
            {
                txt += cb_Carro.Text + ", ";
            }
            if (cb_Aviao.Checked)
            {
                txt += cb_Aviao.Text + ", ";
            }
            if (cb_Navio.Checked)
            {
                txt += cb_Navio.Text + ", ";
            }
            if (cb_Onibus.Checked)
            {
                txt += cb_Onibus.Text + ", ";
            }
            */
            MessageBox.Show(txt);
        }

        private void cb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Patinete.Checked)
            {
                MessageBox.Show("Patinete marcado!");
            }
        }

        private void bt_AFF_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_FilhoCheckBox = new F_filhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
