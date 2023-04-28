/****************************************************************************************
 *                Nome: BDDocumento
 *                Obs.: Representa a Classe de Entidade BDDocumento com Metodos Públicos que irão 
 *                      consultar, inserir, excluir e alterar os dados da tabela TB_DOCUMENTO.
 *         Dt. Criação: 28/03/2023
 *       Dt. Alteração: --/--/----
 *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
 ****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sis_Leitor_Pessoal
{
    class BDDocumento
    {
        ~BDDocumento()
        {

        }
        /****************************************************************************************
        *              Método: FindAllArquivo
        *                Obs.: Responsável por Encontrar todas as Tuplas que estão na tabela 
        *                      TB_DOCUMENTO.
        *             Retorno: uma lista de todos os Objeto Documento
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public List<Documento> FindAllArquivo()
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "SELECT * FROM TB_DOCUMENTO WHERE B_PATH_DOCUMENTO = 1 ";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Documento> Lista = new List<Documento>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Documento obj_Documento = new Documento();

                        obj_Documento.Cod_Documento = Convert.ToInt16(objDtr["I_COD_DOCUMENTO"]);
                        obj_Documento.Ctd_Documento = objDtr["S_CTD_DOCUMENTO"].ToString();
                        obj_Documento.Path_Documento = Convert.ToInt16(objDtr["B_PATH_DOCUMENTO"]);

                        Lista.Add(obj_Documento);

                    }

                }

                objCon.Close();
                objDtr.Close();

                return Lista;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Documento>();
            }


        }
        /****************************************************************************************
        *              Método: FindAllTexto
        *                Obs.: Responsável por Encontrar todas as Tuplas que estão na tabela 
        *                      TB_DOCUMENTO.
        *             Retorno: uma lista de todos os Objeto Documento
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public List<Documento> FindAllTexto()
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "SELECT * FROM TB_DOCUMENTO WHERE B_PATH_DOCUMENTO = 0 ";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Documento> Lista = new List<Documento>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Documento obj_Documento = new Documento();

                        obj_Documento.Cod_Documento = Convert.ToInt16(objDtr["I_COD_DOCUMENTO"]);
                        obj_Documento.Ctd_Documento = objDtr["S_CTD_DOCUMENTO"].ToString();
                        obj_Documento.Path_Documento = Convert.ToInt16(objDtr["B_PATH_DOCUMENTO"]);

                        Lista.Add(obj_Documento);

                    }

                }

                objCon.Close();
                objDtr.Close();

                return Lista;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Documento>();
            }


        }


    }
}
