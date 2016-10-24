using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace XtremeFerramentas
{
    public partial class cadFerramentas : Form
    {
        public cadFerramentas()
        {
            InitializeComponent();
            new Entities.ferramentas().createTableFerramentas();
            new Entities.tipos().createTableTipo();
        }

        private void limpar(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void chb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_add.Checked)
            {
                lbl_num.Enabled = true;
                lbl_fab.Enabled = true;
                lbl_val.Enabled = true;
                lbl_data.Enabled = true;
                lbl_est.Enabled = true;
                lbl_loc.Enabled = true;


                txb_num.Enabled = true;
                txb_fab.Enabled = true;
                txb_vl.Enabled = true;
                mtb_data.Enabled = true;
                cbx_est.Enabled = true;
                txb_lcl.Enabled = true;
            }
            else
            {
                lbl_num.Enabled = false;
                lbl_fab.Enabled = false;
                lbl_val.Enabled = false;
                lbl_data.Enabled = false;
                lbl_est.Enabled = false;
                lbl_loc.Enabled = false;


                txb_num.Enabled = false;
                txb_fab.Enabled = false;
                txb_vl.Enabled = false;
                mtb_data.Enabled = false;
                cbx_est.Enabled = false;
                txb_lcl.Enabled = false;
            }
        }

        private void tsb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            limpar(this.Controls);
            this.chb_add.Checked = false;
        }

        private void cbb_set_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsb_con_Click(object sender, EventArgs e)
        {
            {
                  Data.clsRetorno meuTipo = new Entities.tipos()
                  {
                       codigo = txb_cod.Text.Trim(),
                       tipo = txb_tip.Text.Trim(),
                       setor = cbb_set.Text.Trim()
                    }.inserir();
                if (chb_add.Checked)
                {
                    Data.clsRetorno minhaFerramenta = new Entities.ferramentas()
                    {

                        numeracao = int.Parse(txb_num.Text.Trim()),
                        fabricante = txb_fab.Text.Trim(),
                        valor = double.Parse(txb_vl.Text.Trim()),
                        date = mtb_data.Text.Trim(),
                        localizacao = txb_lcl.Text.Trim(),
                        estado = cbx_est.Text.Trim()
                    }.inserir();
                }
                if (meuTipo.Sucesso)
                {
                    atualizarDados();
                    txb_cod.Text = txb_tip.Text = cbx_est.Text = txb_fab.Text = txb_lcl.Text = txb_num.Text=txb_vl.Text= cbb_set.Text =mtb_data.Text = string.Empty;
                    MessageBox.Show("Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro: {0}", meuTipo.Mensagem);
                }

                
            }
        }
        public void atualizarDados()
        {
            Data.clsRetorno minhaFerramenta = new Entities.ferramentas().carregarFerramentas();
            Data.clsRetorno meuTipo = new Entities.tipos().carregarTipos();


        }

        private void cadFerramentas_Load(object sender, EventArgs e)
        {

        }

        private void cadFerramentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.ferCad--;
        }
    }
}
