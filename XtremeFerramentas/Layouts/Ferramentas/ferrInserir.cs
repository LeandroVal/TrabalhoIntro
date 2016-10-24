using System;
using System.Collections;
using MySql.Data.MySqlClient;
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
    public partial class ferrInserir : Form
    {
        public ferrInserir()
        {
            InitializeComponent();
            new Entities.ferramentas().createTableFerramentas();
        }

        private void reinicializarForm()
        {
            ///// Reinicializa o Formulário
            ///////////////////////////////////////////////////////////////////////////////////////
            foreach (Control ctrl in this.Controls)
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

            ////////////////////////////////////////////////////////////////////////////////////////
        }


        private void cbb_set_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsb_confirmar_Click(object sender, EventArgs e)
        {
            {
                Data.clsRetorno minhaFerramenta = new Entities.ferramentas()
                {
                    /*codigo = txb_cod.Text.Trim(),
                    tipo = txb_tip.Text.Trim(),
                    setor = txb_set.Text.Trim(),*/
                    numeracao = int.Parse(txb_num.Text.Trim()),
                    fabricante = txb_fab.Text.Trim(),
                    valor = double.Parse(txb_val.Text.Trim()),
                    date = mtb_dat.Text.Trim(),
                    localizacao = txb_loc.Text.Trim(),
                    estado = cbb_est.Text.Trim()
                }.inserir();

                if (minhaFerramenta.Sucesso)
                {
                    atualizarDados();
                    txb_fab.Text = txb_loc.Text = txb_num.Text = txb_val.Text = cbb_est.Text = mtb_dat.Text = string.Empty;
                    MessageBox.Show("Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro: {0}", minhaFerramenta.Mensagem);
                }

            }

            reinicializarForm();
        }
        public void atualizarDados()
        {
            Data.clsRetorno minhaFerramenta = new Entities.ferramentas().carregarFerramentas();


        }

        private void tsb_voltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsb_cancelar_Click_1(object sender, EventArgs e)
        {
            reinicializarForm();
        }

        private void ferrInserir_Load(object sender, EventArgs e)
        {

        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {


            string strCmd = string.Empty;

            MySqlConnection ocnn = null;

            ocnn = Data.clsData.RetornaConexao();

            
            strCmd += "SELECT TIPO FROM TIPO";

            MySqlCommand cmd = new MySqlCommand(strCmd, ocnn);

            MySqlDataReader oDR = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (oDR.HasRows)
            {
                while (oDR.Read())
                {   
                    cbb_set.Items.Add(oDR["TIPO"].ToString());

                }
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!");

            }
        }

        private void ferrInserir_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.ferIns--;
        }
    }
}
