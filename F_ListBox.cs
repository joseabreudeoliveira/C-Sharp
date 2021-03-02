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
    public partial class F_ListBox : Form
    {
        //Criando uma lista chamada carro
        List<string> carro = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();

            //Adicionando valores na lista carro
            carro.Add("HRV");
            carro.Add("Golf");
            carro.Add("Focus");

            //Usando data source para adicionar a lista ao componente
            lb_carros.DataSource = carro;
        }
        
        //Criando função
        private void atualizaLB(ListBox lb, List<string>l)
        {
            //limpo e recarrego a lista
            lb.DataSource = null;
            lb.DataSource = l;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carros.Text == "")
            {
                //return;
                MessageBox.Show("Digite um carro");
                tb_carros.Focus();
            }
            else{
                carro.Add(tb_carros.Text);
                tb_carros.Clear();

                //limpo e recarrego a lista
                //Criei função
                //lb_carros.DataSource = null;
                //lb_carros.DataSource = carro;
                atualizaLB(lb_carros, carro);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carro.RemoveAt(lb_carros.SelectedIndex);


            //limpo e recarrego a lista
            //Criei função
            //lb_carros.DataSource = null;
            //lb_carros.DataSource = carro;
            atualizaLB(lb_carros, carro);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carros.Text = carro[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carro.Clear();

            //limpo e recarrego a lista
            //Criei função
            //lb_carros.DataSource = null;
            //lb_carros.DataSource = carro;
            atualizaLB(lb_carros, carro);
        }
    }
}
