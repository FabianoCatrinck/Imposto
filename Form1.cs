using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imposto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            if (float.Parse(edtRendimento.Text) <= 2200)
                MessageBox.Show("ISENTO");
            else
                if ((float.Parse(edtRendimento.Text) > 2200.01) &&
                   (float.Parse(edtRendimento.Text) <= 3400))
                   MessageBox.Show("5%");
                       else
            if ((float.Parse(edtRendimento.Text) > 3400.01) && 
               (float.Parse(edtRendimento.Text) < 5000))
               MessageBox.Show("15%");
            else
              MessageBox.Show("25%");

        }
    }
}
