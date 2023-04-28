/****************************************************************************************
 *                Nome: Usuario
 *                Obs.: Representa a Classe de Entidade Usuario com Atributos Privados e 
 *                      métodos de Get e Set Públicos
 *         Dt. Criação: 28/03/2023
 *       Dt. Alteração: --/--/----
 *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
 ****************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Leitor_Pessoal
{
    public class Usuario
    {
        ~Usuario() 
        { 
        
        }

        #region Atributos Privados
        private int v_Cod_Usuario = -1;
        private string v_Nm_Usuario = "";
        private string v_Email_Usuario = "";
        private string v_Senha_Usuario = "";


        #endregion

        #region Métodos Públicos
        public int Cod_Usuario
        {
            get => v_Cod_Usuario;
            set => v_Cod_Usuario = value;
        }

        public string Nm_Usuario
        {
            get => v_Nm_Usuario;
            set => v_Nm_Usuario = value;
        }

        public string Email_Usuario
        {
            get => v_Email_Usuario;
            set => v_Email_Usuario = value;
        }

        public string Senha_Usuario
        {
            get => v_Senha_Usuario;
            set => v_Senha_Usuario = value;
        }

        #endregion

    }
}