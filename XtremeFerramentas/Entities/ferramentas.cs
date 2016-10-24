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
    class ferramentas
    {
        /*public string codigo { get; set; }
        public string tipo { get; set; }
        public string setor { get; set; }*/
        public string codigo { get; set; }
        public int numeracao { get; set; }
        public string fabricante { get; set; }
        public double valor { get; set; }
        public string date { get; set; }
        public string estado { get; set; }
        public string localizacao { get; set; }

        public void createTableFerramentas()
        {
            MySqlConnection ocnn = null;
            string sqlCmd = string.Empty;
            try
            {
                ocnn = Data.clsData.RetornaConexao();

                sqlCmd += "CREATE TABLE IF NOT EXISTS FERRAMENTAS(CODIGO INT NOT NULL AUTO_INCREMENT, ";
                /*sqlCmd += "TIPO VARCHAR(100), ";
                sqlCmd += "SETOR VARCHAR(100), ";*/
                sqlCmd += "NUMERACAO INT(20) NOT NULL, ";
                sqlCmd += "FABRICANTE VARCHAR(100), ";
                sqlCmd += "VALOR DOUBLE, ";
                sqlCmd += "DATA_AQUISICAO VARCHAR(100), ";
                sqlCmd += "ESTADO VARCHAR(100), ";
                sqlCmd += "LOCALIZACAO VARCHAR(100), ";
                sqlCmd += "PRIMARY KEY (NUMERACAO), ";
                sqlCmd += "FOREIGN KEY (CODIGO) REFERENCES TIPO (CODIGO));";

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

            sqlCmd += "INSERT INTO FERRAMENTAS("
               /* + "TIPO,"
                + " SETOR)"*/
                + "NUMERACAO,"
                + " FABRICANTE,"
                + " VALOR,"
                + " DATA_AQUISICAO,"
                + " ESTADO,"
                + " LOCALIZACAO)"
                + " VALUES ( "
                /*+ "'" + this.tipo.Trim() + "', "
                + "'" + this.setor.Trim() + "', "*/
                + "'" + this.numeracao.ToString().Trim() + "', "
                + "'" + this.fabricante.Trim() + "', "
                + "'" + this.valor + "', "
                + "'" + this.date.Trim() + "', "
                + "'" + this.estado.Trim() + "', "
                + "'" + this.localizacao.Trim() + "'"
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

        public Data.clsRetorno carregarFerramentas()
        {
            Data.clsRetorno oRet = new Data.clsRetorno();
            oRet.Sucesso = false;
            oRet.Mensagem = string.Empty;

            string strCmd = string.Empty;

            MySqlConnection ocnn = null;


            strCmd += "SELECT * FROM FERRAMENTAS";

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
            Entities.ferramentas aFerramenta;

            while (oDR.Read())
            {

                aFerramenta = new Entities.ferramentas();
                aFerramenta.codigo = oDR["CODIGO"].ToString();/*
                aFerramenta.tipo = oDR["TIPO"].ToString();
                aFerramenta.setor = oDR["SETOR"].ToString();*/
                aFerramenta.numeracao = int.Parse(oDR["NUMERACAO"].ToString());
                aFerramenta.fabricante = oDR["FABRICANTE"].ToString();
                aFerramenta.valor = double.Parse(oDR["VALOR"].ToString());
                aFerramenta.date = oDR["DATA_AQUISICAO"].ToString();
                aFerramenta.localizacao = oDR["LOCALIZACAO"].ToString();
                aFerramenta.estado = oDR["ESTADO"].ToString();

                lista.Add(aFerramenta);
            }

            return lista;
        }
    }
}
