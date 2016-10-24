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
    public partial class ConFer : Form
    {
        bool marcado = false;
        public ConFer()
        {
            InitializeComponent();
        }

        public ConFer(int opc)
        {
            InitializeComponent();
            if (opc == 1)
            {
                grb_opc.Enabled = true;
                grb_aca.Enabled = true;

                rbn_tra.Checked = true;
            }

        }

        private void ConFer_FormClosed(object sender, FormClosedEventArgs e)
        {
            janelas.ferCons--;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConFer_Load(object sender, EventArgs e)
        {

        }

        private void ConFer_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*Data.clsRetorno oRet = new Data.clsRetorno();
              oRet.Sucesso = false;
              oRet.Mensagem = string.Empty;*/

            if ((e.KeyChar == 13)&&(!marcado))
            {
                marcado = true;
                string strCmd = string.Empty;

                MySqlConnection ocnn = null;


                strCmd += "SELECT * FROM TIPO T, FERRAMENTAS F WHERE T.CODIGO = F.CODIGO";

                try
                {
                    ocnn = Data.clsData.RetornaConexao();

                    MySqlCommand cmd = new MySqlCommand(strCmd, ocnn);

                    MySqlDataReader oDR = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    int nColunas = oDR.FieldCount;

                    for (int i = 0; i < nColunas; i++)
                    {
                        dataGridView1.Columns.Add(oDR.GetName(i).ToString(), oDR.GetName(i).ToString());
                    }

                    string[] linhaDados = new string[nColunas];
                    while (oDR.Read())
                    {
                        for (int a = 0; a < nColunas; a++)
                        {
                            if (oDR.GetFieldType(a).ToString() == "System.Int32")
                            {
                                linhaDados[a] = oDR.GetInt32(a).ToString();
                            }
                            if (oDR.GetFieldType(a).ToString() == "System.DateTime")
                            {
                                linhaDados[a] = oDR.GetDateTime(a).ToString();
                            }
                            if (oDR.GetFieldType(a).ToString() == "System.String")
                            {
                                linhaDados[a] = oDR.GetString(a).ToString();
                            }
                            if (oDR.GetFieldType(a).ToString() == "System.Int16")
                            {
                                linhaDados[a] = oDR.GetInt16(a).ToString();
                            }
                            if (oDR.GetFieldType(a).ToString() == "System.Double")
                            {
                                linhaDados[a] = oDR.GetDouble(a).ToString();
                            }
                        }

                        dataGridView1.Rows.Add(linhaDados);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    if (ocnn.State == ConnectionState.Open)
                        ocnn.Close();
                }
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
