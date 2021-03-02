using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;          /*Eu inseri para utilizar o Slip*/

namespace Componentes
{
    public partial class F_Progressbar : Form
    {
        public F_Progressbar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if((int.Parse(textBox1.Text) >= progressBar1.Minimum) & (int.Parse(textBox1.Text) <= progressBar1.Maximum))
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            /*Eu inseri para utilizar o Slip o using System.Threading
            progressBar1.Value = 0;
            for (int i= 0 ; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(200);
            }
            */
            /*Outra forma*/
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text);
            for (int i = 0; i <= int.Parse(textBox2.Text); i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;
            }
        }
    }
}
