/****************************************************************************************
 *                Nome: Documento
 *                Obs.: Representa a Classe de Entidade Documento com Atributos Privados e 
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
    public class Documento
    {
        ~Documento()
        {

        }

        #region Atributos Privados
        private int v_Cod_Documento = -1;
        private string v_Ctd_Documento = "";
        private int v_Path_Documento = -1;
        #endregion

        #region Métodos Públicos
        public int Cod_Documento
        {
            get => v_Cod_Documento;
            set => v_Cod_Documento = value;
        }

        public string Ctd_Documento
        {
            get => v_Ctd_Documento;
            set => v_Ctd_Documento = value;
        }

        public int Path_Documento
        {
            get => v_Path_Documento;
            set => v_Path_Documento = value;
        }

        #endregion

    }
}
