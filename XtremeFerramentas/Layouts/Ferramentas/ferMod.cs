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
    public partial class ferMod : Form
    {
        public ferMod()
        {
            InitializeComponent();
        }

        private void reinicializarForm()
        {
            ///// Reinicializa o Formulário
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Enabled = false;
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Enabled = false;
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)(ctrl)).Enabled = false;
                    ((ComboBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Checked = false;
                    ((CheckBox)(ctrl)).Enabled = false;
                }
            }

        }

        private void ferMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.ferMod--;
        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {
            ConFer Confer = new ConFer(1);
            Confer.ShowDialog();
        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            reinicializarForm();
        }

        private void tsb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsb_confirmar_Click(object sender, EventArgs e)
        {
            var yn = DialogResult.No;
            bool mod = false;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox)
                {
                    if (((CheckBox)(ctrl)).Checked == true)
                    {
                        mod = true;
                        break;
                    }
                }
            }
            if (mod)
            {
                string texto = "Deseja modificar os dados marcados?";
                yn = MessageBox.Show(texto, "Deseja Prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (yn == DialogResult.Yes)
            {
                //////////////////////////////////////////////////////////
                ////////////////////////////////////// Colocar Aqui código para comunicação com o Banco
                ////////////////////////////////////////////////////////////

                MessageBox.Show("Os dados que estavam selecionados foram modificados", "Dados Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);


                reinicializarForm();


            }
        }
    }
}
