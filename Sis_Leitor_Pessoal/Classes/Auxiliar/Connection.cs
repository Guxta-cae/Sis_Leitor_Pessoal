/****************************************************************************************
 *                Nome: Connection
 *                Obs.: Representa a Classe de conexão com a Base de dados
 *         Dt. Criação: 28/03/2023
 *       Dt. Alteração: --/--/----
 *          Criada por: Angéllica Barbosa, Gustavo Caetano e Lucas Isaac
 ****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Leitor_Pessoal
{
    class Connection
    {
        ~Connection()
        {

        }

        /****************************************************************************************
 *              Método: PathConnection
 *                Obs.: Responsável por retornar o caminho de onde o banco está
 *                      salvo na máquina local
 *             Retorno: Path do BD.
 *         Dt. Criação: 28/03/2023
 *       Dt. Alteração: --/--/----
 *          Criada por: Angéllica Barbosa, Gustavo Caetano e Lucas Isaac
 ****************************************************************************************/
        public static string PathConnection()
        {
            //Pega o caminho do executável da aplicação e retorna o mesmo
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            //Retorna a string de conexão
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\Gustavo\source\repos\GH - SisLeitorPessoal\Sis_Leitor_Pessoal\Sis_Leitor_Pessoal\Sis_Leitor_Pessoal\BD_SISLEITORPESSOAL.mdf;Integrated Security=True;Connect Timeout = 15";

            //return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "BD_SISLEITORPESSOAL.mdf";
            //return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\gustavo.calves2\source\repos\Sis_Leitor_Pessoal\Sis_Leitor_Pessoal\BD_SISLEITORPESSOAL.mdf;Integrated Security=True;Connect Timeout = 15";
        }


    }
}