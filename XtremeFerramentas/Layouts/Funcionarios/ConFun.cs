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
    public partial class ConFun : Form
    {
        public ConFun()
        {
            InitializeComponent();
        }

        private void ConFun_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.funCon--;
        }
    }
}
