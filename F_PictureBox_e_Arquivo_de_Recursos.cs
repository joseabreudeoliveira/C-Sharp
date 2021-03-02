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
    public partial class F_PictureBox_e_Arquivo_de_Recursos : Form
    {
        public F_PictureBox_e_Arquivo_de_Recursos()
        {
            InitializeComponent();
        }

        private void F_PictureBox_e_Arquivo_de_Recursos_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.EndereçoCanal;
        }

        private void btn_logo1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Image1;
        }

        private void btn_logo2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Image2;
        }
    }
}
