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
    public partial class conset : Form
    {
        public conset()
        {
            InitializeComponent();
        }

        private void conset_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.setCon--;
        }
    }
}
