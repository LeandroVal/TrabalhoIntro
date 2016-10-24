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
    public partial class funcConsDeb : Form
    {
        public funcConsDeb()
        {
            InitializeComponent();
        }

        private void funcConsDeb_Load(object sender, EventArgs e)
        {
            janelas.funDeb--;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
