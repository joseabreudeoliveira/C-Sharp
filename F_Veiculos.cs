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
    public partial class F_Veiculos : Form
    {
        F_Principal fp;  //criado para ser visivel dentro de private void F_Veiculos_FormClosed
                         //fp ficou global para toda a classe F_Veiculos
        public F_Veiculos(string v, F_Principal f) //para F_Principal fp funcionar foi posto this
        {                                           // no formulario pai fomr1
            InitializeComponent();

            tb_listaVeiculos.Text = v;

            fp = f;

            fp.num=10;                               // consigo acessar pois é publica
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
