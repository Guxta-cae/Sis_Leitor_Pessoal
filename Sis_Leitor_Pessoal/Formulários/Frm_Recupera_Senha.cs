using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections;
using System.Net.Mail;

namespace Sis_Leitor_Pessoal
{
    public partial class Frm_Recupera_Senha : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Usuario obj_Usuario_Atual = new Usuario();
        string cod = "";

        public Frm_Recupera_Senha()
        {
            InitializeComponent();
        }

        /****************************************************************************************
        *              Método: GerarSenhas
        *                Obs.: Responsável por criar o código para redefinir a senha. 
        *         Dt. Criação: 20/04/2023
        *       Dt. Alteração: --/--/----
        *          Criada por: Angélica Barbosa, Gustavo Caetano e Lucas Isaac
        *          Observação: --
        ****************************************************************************************/
        private string GerarSenhas()
        {
            int tamanho = 10; // Numero de digitos da senha
            string caracter = string.Empty;
            for (int i = 0; i < tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!caracter.Contains(_char))
                    {
                        caracter += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return caracter;
        }

        //Fazer função de enviar o email
        /*
        private MailMessage SendMail()
        {
            return;
        }
        */

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            BDUsuario obj_BDUsuario = new BDUsuario();

            if (tbox_Email_Rec.Text != "")
            {
                obj_Usuario_Atual.Email_Usuario = tbox_Email_Rec.Text;

                if (!obj_BDUsuario.ExistByMail(obj_Usuario_Atual))
                {
                    MessageBox.Show("Email inválido!", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                obj_Usuario_Atual = obj_BDUsuario.FindByMail(obj_Usuario_Atual);

                //Usa os system adequados e prepara o smtp
                System.Net.Mail.SmtpClient Smtp = new System.Net.Mail.SmtpClient();
                Smtp.Host = "smtp.gmail.com";
                Smtp.EnableSsl = true;

                //Passa o login do email
                Smtp.Credentials = new System.Net.NetworkCredential("gustavo.calves@outlook.com", "gu123456789");

                //Istancia uma variavel da classe Email
                MailMessage mail = new MailMessage();

                //Passa as informações do enviador e do recebedor
                mail.Sender = new System.Net.Mail.MailAddress("gustavo.calves@outlook.com", "ENVIADOR");
                mail.From = new MailAddress("gustavo.calves@outlook.com", "ENVIADOR");
                mail.To.Add(new MailAddress("" + obj_Usuario_Atual.Email_Usuario, "RECEBEDOR"));

                //Gera o código 
                cod = GerarSenhas();

                //Mensagem
                mail.Subject = "Contato";
                mail.Body = " Mensagem do site:<br/> Nome:  " + obj_Usuario_Atual.Nm_Usuario + "<br/> Email : " + obj_Usuario_Atual.Email_Usuario + " <br/> Mensagem : Seu código de acesso é: " + cod;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                try
                {
                    //Tenta enviar o email
                    Smtp.Send(mail);
                }
                catch (System.Exception erro)
                {
                    //Erro
                    MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha o Email para receber o código!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbox_Email_Rec.Focus();
            }
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if (tbox_Cod_Rec.Text != "")
            {
                if(tbox_Cod_Rec.Text == cod)
                {
                    MessageBox.Show("Código correto!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //habilita o botão de redefinir 
                }
                else
                {
                    MessageBox.Show("Código incorreto!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha o Código para alterar a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbox_Email_Rec.Focus();
            }
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

            obj_Usuario.Senha_Usuario = obj_FuncGeral.Criptografa(tbox_NSenha_Rec.Text);

            return obj_Usuario;
        }

        private void btn_Redefinir_Click(object sender, EventArgs e)
        {
            if (tbox_NSenha_Rec.Text != "")
            {
                BDUsuario obj_BDUsuario = new BDUsuario();

                obj_Usuario_Atual = PopulaObjeto();
                if (obj_BDUsuario.Alterar(obj_Usuario_Atual))
                {
                    MessageBox.Show("A Senha foi Alterada com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar sua senha.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha com uma senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbox_Email_Rec.Focus();
            }
        }
    }
}
