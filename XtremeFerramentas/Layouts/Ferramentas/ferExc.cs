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
    public partial class ferExc : Form
    {
        public ferExc()
        {
            InitializeComponent();
        }

        private void reinicializarForm()
        {
            ///// Reinicializa o Formulário
            ///////////////////////////////////////////////////////////////////////////////////////
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
            }

            lbl_cod.Enabled = true;
            txb_cod.Enabled = true;

            lbl_num.Enabled = true;
            txb_num.Enabled = true;
            ////////////////////////////////////////////////////////////////////////////////////////
        }



        private void ferExc_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.ferExc--;  //Incrementa contador para impedir que o form seja aberta duas vezes
        }

        private void tsb_voltar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o form
        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            reinicializarForm();
        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {
            ////// Abre o form de busca com contrutor sobrecarregado
            ////////////////////////////////////////////////////////
            ConFer Confer = new ConFer(1);
            Confer.ShowDialog();
            ///////////////////////////////////////////////////////
        }

        private void tsb_confirmar_Click(object sender, EventArgs e)
        {
            var yn = DialogResult.No;

            ///////// Verifica o que será excluido (Tipo ou ferramenta) e emite uma mensagem para que o usuário confirme.
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (lbl_fab.Enabled && lbl_tipo.Enabled)
            {
                string texto = "Deseja remover o Tipo " + txb_tip.Text + " e a ferramenta de númeração " + txb_num.Text + " ?";
                yn = MessageBox.Show(texto, "Deseja Prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            else if (lbl_fab.Enabled)
            {
                string texto = "Deseja remover o Tipo " + txb_tip.Text + " ?";
                yn = MessageBox.Show(texto, "Deseja Prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (lbl_tipo.Enabled)
            {
                string texto = "Deseja remover a ferramenta de númeração " + txb_num.Text + " ?";
                yn = MessageBox.Show(texto, "Deseja Prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (yn == DialogResult.Yes)
            {
                //////////////////////////////////////////////////////////
                ////////////////////////////////////// Colocar Aqui código para comunicação com o Banco
                ////////////////////////////////////////////////////////////

                MessageBox.Show("Os dados foram removidos", "Dados Removidos", MessageBoxButtons.OK, MessageBoxIcon.Information);



                reinicializarForm();
            }
        }
    }
}
