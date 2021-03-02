﻿using System;
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
    public partial class F_filhoCheckBox : Form
    {
        public F_CheckBox fcb;  //1-Criei uma variavel global
        public F_filhoCheckBox()
        {
            InitializeComponent();

            //Verifica se o formulario esta aberto
            //if (Application.OpenForms["F_CheckBox"].Created)
            try
            {
                fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox; //2-Associei ao construtor
                cb_Carro.Checked = fcb.cb_Carro.Checked;
                cb_Aviao.Checked = fcb.cb_Aviao.Checked;
                cb_Navio.Checked = fcb.cb_Navio.Checked;
                cb_Onibus.Checked = fcb.cb_Onibus.Checked;
            }
            catch
            {
                MessageBox.Show("erro ao abrir formulario.");
            }
        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_Carro.Checked = cb_Carro.Checked;
        }

        private void cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_Aviao.Checked = cb_Aviao.Checked;
        }

        private void cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_Navio.Checked = cb_Navio.Checked;
        }

        private void cb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_Onibus.Checked = cb_Onibus.Checked;
        }
    }
}
