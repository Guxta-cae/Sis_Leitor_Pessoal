/****************************************************************************************
 *                Nome: BDUsuario
 *                Obs.: Representa a Classe de Entidade BDUsuario com Metodos Públicos que irão 
 *                      consultar, inserir, excluir e alterar os dados da tabela TB_USUARIO.
 *         Dt. Criação: 28/03/2023
 *       Dt. Alteração: --/--/----
 *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
 ****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sis_Leitor_Pessoal
{
    class BDUsuario
    {
        ~BDUsuario()
        {

        }

        /****************************************************************************************
        *              Método: Incluir
        *                Obs.: Responsável por incluir a Tupla que está no objeto Usuario na tabela
        *                      TB_USUARIO.
        *           Parametro: Objeto Usuario
        *             Retorno: PK da Tupla inserida na tabela TB_USUARIO.
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public int Incluir(Usuario pobj_Usuario)
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "INSERT INTO TB_USUARIO " +
                          "( " +
                          "S_NM_USUARIO, " +
                          "S_EMAIL_USUARIO, " +
                          "S_SENHA_USUARIO " +
                          ") " +
                          "VALUES " +
                          "( " +
                          "@S_NM_USUARIO, " +
                          "@S_EMAIL_USUARIO, " +
                          "@S_SENHA_USUARIO " +
                          "); " +
                          "SELECT IDENT_CURRENT('TB_USUARIO') AS 'CODPK'";
            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            objCmd.Parameters.AddWithValue("@S_NM_USUARIO", pobj_Usuario.Nm_Usuario);
            objCmd.Parameters.AddWithValue("@S_EMAIL_USUARIO", pobj_Usuario.Email_Usuario);
            objCmd.Parameters.AddWithValue("@S_SENHA_USUARIO", pobj_Usuario.Senha_Usuario);

            try
            {
                objCon.Open();
                int iCod = Convert.ToInt16(objCmd.ExecuteScalar());
                objCon.Close();
                return iCod;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return pobj_Usuario.Cod_Usuario;
            }
        }

        /****************************************************************************************
        *              Método: Alterar
        *                Obs.: Responsável por Alterar a Tupla que está no objeto Usuario na tabela
        *                      TB_USUARIO.
        *           Parametro: Objeto Usuario
        *             Retorno: Booleano
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public bool Alterar(Usuario pobj_Usuario)
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "UPDATE TB_USUARIO SET " +
                          "S_NM_USUARIO = @S_NM_USUARIO, " +
                          "S_EMAIL_USUARIO = @S_EMAIL_USUARIO, " +
                          "S_SENHA_USUARIO = @S_SENHA_USUARIO " +
                          "WHERE I_COD_USUARIO = @I_COD_USUARIO";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);
            objCmd.Parameters.AddWithValue("@S_NM_USUARIO", pobj_Usuario.Nm_Usuario);
            objCmd.Parameters.AddWithValue("@S_EMAIL_USUARIO", pobj_Usuario.Email_Usuario);
            objCmd.Parameters.AddWithValue("@S_SENHA_USUARIO", pobj_Usuario.Senha_Usuario);

            try
            {
                objCon.Open();
                objCmd.ExecuteNonQuery();
                objCon.Close();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /****************************************************************************************
        *              Método: Excluir
        *                Obs.: Responsável por Excluir a Tupla que está no objeto Usuario na tabela
        *                      TB_USUARIO.
        *           Parametro: Objeto Usuario
        *             Retorno: Booleano
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public bool Excluir(Usuario pobj_Usuario)
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "DELETE FROM TB_USUARIO " +
                          "WHERE I_COD_USUARIO = @I_COD_USUARIO";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);

            try
            {
                objCon.Open();
                objCmd.ExecuteNonQuery();
                objCon.Close();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /****************************************************************************************
        *              Método: FindByCod
        *                Obs.: Responsável por Encontrar a Tupla que está na tabela TB_USUARIO pelo
        *                      Códido da agenda.
        *           Parametro: Objeto Usuario (Vazio)
        *             Retorno: Objeto Usuario (Cheio)
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public Usuario FindByCod(Usuario pobj_Usuario)
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "SELECT * FROM TB_USUARIO " +
                          "WHERE I_COD_USUARIO = @I_COD_USUARIO";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);

            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    objDtr.Read();

                    pobj_Usuario.Cod_Usuario = Convert.ToInt16(objDtr["I_COD_USUARIO"]);
                    pobj_Usuario.Nm_Usuario = objDtr["S_NM_USUARIO"].ToString();
                    pobj_Usuario.Email_Usuario = objDtr["S_EMAIL_USUARIO"].ToString();
                    pobj_Usuario.Senha_Usuario = objDtr["S_SENHA_USUARIO"].ToString();

                    objCon.Close();
                    objDtr.Close();

                    return pobj_Usuario;
                }
                else
                {
                    objCon.Close();
                    return pobj_Usuario;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return pobj_Usuario;
            }
        }

        /****************************************************************************************
        *              Método: ExistByMail
        *                Obs.: Responsável por Encontrar a Tupla que está na tabela TB_USUARIO pelo
        *                      Email do Usuário.
        *           Parametro: Objeto Usuario com o email.
        *             Retorno: Bool
        *         Dt. Criação: 20/04/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public bool ExistByMail(Usuario pobj_Usuario)
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "SELECT * FROM TB_USUARIO " +
                          "WHERE S_EMAIL_USUARIO = @S_EMAIL_USUARIO";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            objCmd.Parameters.AddWithValue("@S_EMAIL_USUARIO", pobj_Usuario.Email_Usuario);

            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                if (objDtr.HasRows)
                {
                    objCon.Close();
                    objDtr.Close();

                    return true;
                }
                else
                {
                    objCon.Close();
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        /****************************************************************************************
        *              Método: FindByMail
        *                Obs.: Responsável por Encontrar a Tupla que está na tabela TB_USUARIO pelo
        *                      Email do Usuário.
        *           Parametro: Objeto Usuario (Vazio)
        *             Retorno: Objeto Usuario (Cheio)
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
                public Usuario FindByMail(Usuario pobj_Usuario)
                {
                    //Criar minha Conexão
                    SqlConnection objCon = new SqlConnection(Connection.PathConnection());

                    string sSQL = "SELECT * FROM TB_USUARIO " +
                                  "WHERE S_EMAIL_USUARIO = @S_EMAIL_USUARIO";

                    SqlCommand objCmd = new SqlCommand(sSQL, objCon);

                    objCmd.Parameters.AddWithValue("@S_EMAIL_USUARIO", pobj_Usuario.Email_Usuario);

                    try
                    {
                        objCon.Open();
                        SqlDataReader objDtr = objCmd.ExecuteReader();

                        if (objDtr.HasRows)
                        {
                            objDtr.Read();

                            pobj_Usuario.Cod_Usuario = Convert.ToInt16(objDtr["I_COD_USUARIO"]);
                            pobj_Usuario.Nm_Usuario = objDtr["S_NM_USUARIO"].ToString();
                            pobj_Usuario.Email_Usuario = objDtr["S_EMAIL_USUARIO"].ToString();
                            pobj_Usuario.Senha_Usuario = objDtr["S_SENHA_USUARIO"].ToString();

                            objCon.Close();
                            objDtr.Close();

                            return pobj_Usuario;
                        }
                        else
                        { 
                            return null;
                        }

                        objCon.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return pobj_Usuario;
                    }
                }

        /****************************************************************************************
        *              Método: FindAll
        *                Obs.: Responsável por Encontrar todas as Tuplas que estão na tabela 
        *                      TB_USUARIO.
        *             Retorno: uma lista de todos os Objeto Usuario
        *         Dt. Criação: 28/03/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: Este Metodo utiliza uma classe auxiliar para conexão com o BD.
        ****************************************************************************************/
        public List<Usuario> FindAll()
        {
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "SELECT * FROM TB_USUARIO ";

            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            try
            {
                objCon.Open();
                SqlDataReader objDtr = objCmd.ExecuteReader();

                List<Usuario> Lista = new List<Usuario>();

                if (objDtr.HasRows)
                {
                    while (objDtr.Read())
                    {
                        Usuario obj_Usuario = new Usuario();

                        obj_Usuario.Cod_Usuario = Convert.ToInt16(objDtr["I_COD_USUARIO"]);
                        obj_Usuario.Nm_Usuario = objDtr["S_NM_USUARIO"].ToString();
                        obj_Usuario.Email_Usuario = objDtr["S_EMAIL_USUARIO"].ToString();
                        obj_Usuario.Senha_Usuario = objDtr["S_SENHA_USUARIO"].ToString();

                        Lista.Add(obj_Usuario);

                    }

                }

                objCon.Close();
                objDtr.Close();

                return Lista;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Usuario>();
            }
        }


    }
}
