using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Leitor_Pessoal
{
    public partial class Frm_Cadastro : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Usuario obj_Usuario_Atual = new Usuario();


        public Frm_Cadastro()
        {
            InitializeComponent();
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 1); //Status do botão Cadastrar
        }

        /****************************************************************************************
        *              Método: PopulaObjeto
        *                Obs.: Responsável por preencher o objeto com o conteúdo dos objetos 
        *                      editáveis da Tela.
        *         Dt. Criação: 04/04/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: --
        ****************************************************************************************/

        private Usuario PopulaObjeto()
        {
            Usuario obj_Usuario = new Usuario();

            obj_Usuario.Nm_Usuario = tbox_Nm_Usuario.Text;
            obj_Usuario.Email_Usuario = tbox_Email_Usuario.Text;
            obj_Usuario.Senha_Usuario = obj_FuncGeral.Criptografa(tbox_Senha_Usuario.Text);

            return obj_Usuario;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (tbox_Nm_Usuario.Text != "" && tbox_Email_Usuario.Text != "" && tbox_Senha_Usuario.Text != "")
            {
                BDUsuario obj_BDUsuario = new BDUsuario();

                obj_Usuario_Atual.Email_Usuario = tbox_Email_Usuario.Text;

                //Não está chegando o email pelo findbymail
                if (obj_BDUsuario.ExistByMail(obj_Usuario_Atual))
                {
                    MessageBox.Show("O Email " + obj_Usuario_Atual.Email_Usuario + " já foi Cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    obj_Usuario_Atual = PopulaObjeto();
                    obj_Usuario_Atual.Cod_Usuario = obj_BDUsuario.Incluir(obj_Usuario_Atual);
                    MessageBox.Show("O Usuario " + obj_Usuario_Atual.Nm_Usuario + " foi Incluido com sucesso.", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todas as informações para cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
