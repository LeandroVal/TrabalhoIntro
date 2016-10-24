using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace XtremeFerramentas.Entities
{
    class tipos
    {
        public string codigo { get; set; }
        public string tipo { get; set; }
        public string setor { get; set; }
        /*public int numeracao { get; set; }
        public string fabricante { get; set; }
        public double valor { get; set; }
        public string date { get; set; }
        public string estado { get; set; }
        public string localizacao { get; set; }*/

        public void createTableTipo()
        {
            MySqlConnection ocnn = null;
            string sqlCmd = string.Empty;
            try
            {
                ocnn = Data.clsData.RetornaConexao();

                sqlCmd += "CREATE TABLE IF NOT EXISTS TIPO(CODIGO INT NOT NULL AUTO_INCREMENT, ";
                sqlCmd += "TIPO VARCHAR(100), ";
                sqlCmd += "SETOR VARCHAR(100), ";/*
                sqlCmd += "NUMERACAO INT(20), ";
                sqlCmd += "FABRICANTE VARCHAR(100), ";
                sqlCmd += "VALOR DOUBLE, ";
                sqlCmd += "DATA_AQUISICAO VARCHAR(100), ";
                sqlCmd += "ESTADO VARCHAR(100), ";
                sqlCmd += "LOCALIZACAO VARCHAR(100), ";*/
                sqlCmd += "PRIMARY KEY (CODIGO));";

                MySqlCommand ocmd = new MySqlCommand(sqlCmd, ocnn);
                ocmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                if (ocnn.State == ConnectionState.Open)
                    ocnn.Close();

            }
        }

        public Data.clsRetorno inserir()
        {
            Data.clsRetorno oRet = new Data.clsRetorno();
            oRet.Mensagem = string.Empty;
            oRet.Sucesso = false;

            MySqlConnection ocnn = null;
            string sqlCmd = string.Empty;

            sqlCmd += "INSERT INTO TIPO("
                + "TIPO,"
                + " SETOR)"/*
                + " NUMERACAO,"
                + " FABRICANTE,"
                + " VALOR,"
                + " DATA_AQUISICAO,"
                + " ESTADO,"
                + " LOCALIZACAO)"*/
                + " VALUES ( "
                + "'" + this.tipo.Trim() + "', "
                + "'" + this.setor.Trim() + "'"/*
                + "'" + this.numeracao.ToString().Trim() + "', "
                + "'" + this.fabricante.Trim() + "', "
                + "'" + this.valor.ToString().Trim() + "', "
                + "'" + this.date.Trim() + "', "
                + "'" + this.estado.Trim() + "', "
                + "'" + this.localizacao.Trim() + "'"*/
                + ");";
            try
            {
                ocnn = Data.clsData.RetornaConexao();
                MySqlCommand ocmd = new MySqlCommand(sqlCmd, ocnn);

                int qtdeQueryAfecteds = ocmd.ExecuteNonQuery();

                if (qtdeQueryAfecteds > 0)
                {
                    oRet.Mensagem = "Registro salvo com sucesso!";
                    oRet.Sucesso = true;
                    oRet.ListaAux = null;
                }
                else
                {
                    oRet.Mensagem = "Nenhum registro alterado!";
                    oRet.Sucesso = true;
                    oRet.ListaAux = null;
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
            return oRet;
        }

        public Data.clsRetorno carregarTipos()
        {
            Data.clsRetorno oRet = new Data.clsRetorno();
            oRet.Sucesso = false;
            oRet.Mensagem = string.Empty;

            string strCmd = string.Empty;

            MySqlConnection ocnn = null;


            strCmd += "SELECT * FROM TIPO";

            try
            {
                ocnn = Data.clsData.RetornaConexao();

                MySqlCommand cmd = new MySqlCommand(strCmd, ocnn);

                MySqlDataReader oDR = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (oDR.HasRows)
                {
                    oRet.Sucesso = true;
                    oRet.Mensagem = "Registro atualizado com sucesso";
                    oRet.ListaAux = ObterLista(oDR);
                }
                else
                {
                    oRet.Sucesso = false;
                    oRet.Mensagem = "Nenhum registro alterado";
                    oRet.ListaAux = new ArrayList();
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

            return oRet;
        }

        private ArrayList ObterLista(MySqlDataReader oDR)
        {
            ArrayList lista = new ArrayList();
            Entities.tipos oTipo;

            while (oDR.Read())
            {

                oTipo = new Entities.tipos();
                oTipo.codigo = oDR["CODIGO"].ToString();
                oTipo.tipo = oDR["TIPO"].ToString();
                oTipo.setor = oDR["SETOR"].ToString();/*
                aFerramenta.numeracao = int.Parse(oDR["NUMERACAO"].ToString());
                aFerramenta.fabricante = oDR["FABRICANTE"].ToString();
                aFerramenta.valor = int.Parse(oDR["VALOR"].ToString());
                aFerramenta.date = oDR["DATA_AQUISICAO"].ToString();
                aFerramenta.localizacao = oDR["LOCALIZACAO"].ToString();
                aFerramenta.estado = oDR["ESTADO"].ToString();*/

                lista.Add(oTipo);
            }

            return lista;
        }
    }
}
