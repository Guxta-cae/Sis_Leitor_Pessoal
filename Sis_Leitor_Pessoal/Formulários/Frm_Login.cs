using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sis_Leitor_Pessoal
{
    public partial class Frm_Login : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Usuario obj_Usuario_Atual = new Usuario();

        Thread trd;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            BDUsuario obj_BDUsuario = new BDUsuario();

            if (tbox_Senha_Login.Text != "")
            {
                if (tbox_Email_Login.Text != "")
                {
                    obj_Usuario_Atual.Email_Usuario = tbox_Email_Login.Text;

                    if (!obj_BDUsuario.ExistByMail(obj_Usuario_Atual))
                    {
                        MessageBox.Show("Email inválido!", "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        obj_Usuario_Atual = obj_BDUsuario.FindByMail(obj_Usuario_Atual);

                        if (tbox_Senha_Login.Text == obj_FuncGeral.DesCriptografa(obj_Usuario_Atual.Senha_Usuario))
                        {
                            Frm_Principal obj_Frm_Principal = new Frm_Principal();
                            obj_Frm_Principal.obj_Usuario_Atual = obj_Usuario_Atual;
                            obj_Frm_Principal.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("ERRO AO DESCRIPTOGRAFAR!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todas as informações para logar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbox_Email_Login.Focus();
                }
            }
            else
            {
                MessageBox.Show("Preencha todas as informações para logar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbox_Senha_Login.Focus();
            }
        }

        private void cbox_Visual_Click(object sender, EventArgs e)
        {
            if (cbox_Visual.Checked)
            {
                tbox_Senha_Login.UseSystemPasswordChar = false;
            }
            else
            {
                tbox_Senha_Login.UseSystemPasswordChar = true;
            }
        }

        private void btn_Nv_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_Cadastro obj_Frm_Cadastro = new Frm_Cadastro();
            obj_Frm_Cadastro.ShowDialog();
        }

        private void btn_Esq_Senha_Click(object sender, EventArgs e)
        {
            Frm_Recupera_Senha obj_Frm_Recupera_Senha = new Frm_Recupera_Senha();
            obj_Frm_Recupera_Senha.ShowDialog();
        }
    }
}
