using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void btnNewCat_Click(object sender, EventArgs e)
        {
            frmCategoria cat = new frmCategoria();
            cat.ShowDialog();
        }
    }
}
