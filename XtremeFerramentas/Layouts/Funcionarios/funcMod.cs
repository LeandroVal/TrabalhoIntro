using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeFerramentas
{
    public partial class funcMod : Form
    {
        public funcMod()
        {
            InitializeComponent();
        }

        private void funcMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.funMod--;
        }

        private void tsb_con_Click(object sender, EventArgs e)
        {

        }
    }
}
