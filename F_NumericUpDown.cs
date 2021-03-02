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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if((Decimal.Parse(tb_valor.Text) >= numericUpDown1.Minimum) &
               (Decimal.Parse(tb_valor.Text) <= numericUpDown1.Maximum))
            {
                numericUpDown1.Value = Decimal.Parse(tb_valor.Text);
            }
            else
            {
                MessageBox.Show("O valor digitado tem que ser um valor entre " + numericUpDown1.Minimum + " e " + numericUpDown1.Maximum);
            }
        }
    }
}
