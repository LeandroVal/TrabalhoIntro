﻿using System;
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
    public partial class cefDevolucao : Form
    {
        public cefDevolucao()
        {
            InitializeComponent();
        }

        private void cefDevolucao_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.ferDevol--;
        }
    }
}
