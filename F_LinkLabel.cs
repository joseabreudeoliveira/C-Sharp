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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            //Exemplo de Multiplos Links
            ll_multiplosLinks.Links.Add(0, 6, "http://google.com.br");          //Coleção Link[0]
            ll_multiplosLinks.Links.Add(9, 5, "http://youtube.com/cfbcursos");  //Coleção Link[1]
            ll_multiplosLinks.Links.Add(17, 7, "http://youtube.com");           //Coleção Link[2]

            //Exemplo de Multiplos Links - Desebilitando um dos links
            //Como é uma coleção é so pegar a posição e desabilitar
            ll_multiplosLinks.Links[1].Enabled = false;

        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tb_nome.Text is null)
            {
                System.Diagnostics.Process.Start("http://youtube.com/cfbcursos");
            }
            else
            {
                //Se fosse chamando uma pagina php daria para passar o parametro de um campo tb_nome
                System.Diagnostics.Process.Start("http://youtube.com/cfbcursos" + tb_nome.Text);

                //Marcar o link como visitado.
                //ll_canal.LinkVisited = true;
                //ou
                LinkLabel ll = (LinkLabel)sender;
                ll.LinkVisited = true;
            }
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

            //Marcar o link como visitado.
            //ll_calculadora.LinkVisited = true;
            //ou
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            //Marcar o link como visitado.
            e.Link.Visited = true;
        }
    }
}
