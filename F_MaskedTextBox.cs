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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mtb_CPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                mtb_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            String str = mtb_CPF.Text;
            MessageBox.Show(str);
        }
    }
}
