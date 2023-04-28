namespace Sis_Leitor_Pessoal
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Botao = new System.Windows.Forms.Panel();
            this.btn_Esq_Senha = new System.Windows.Forms.Button();
            this.btn_Nv_Cadastro = new System.Windows.Forms.Button();
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.tbox_Senha_Login = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.tbox_Email_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Botao.SuspendLayout();
            this.pnl_Detalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.Thistle;
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(368, 73);
            this.pnl_Titulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // pnl_Botao
            // 
            this.pnl_Botao.BackColor = System.Drawing.Color.Thistle;
            this.pnl_Botao.Controls.Add(this.btn_Esq_Senha);
            this.pnl_Botao.Controls.Add(this.btn_Nv_Cadastro);
            this.pnl_Botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botao.Location = new System.Drawing.Point(0, 302);
            this.pnl_Botao.Name = "pnl_Botao";
            this.pnl_Botao.Size = new System.Drawing.Size(368, 69);
            this.pnl_Botao.TabIndex = 1;
            // 
            // btn_Esq_Senha
            // 
            this.btn_Esq_Senha.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Esq_Senha.Location = new System.Drawing.Point(251, 34);
            this.btn_Esq_Senha.Name = "btn_Esq_Senha";
            this.btn_Esq_Senha.Size = new System.Drawing.Size(105, 23);
            this.btn_Esq_Senha.TabIndex = 2;
            this.btn_Esq_Senha.Text = "Esqueci a senha";
            this.btn_Esq_Senha.UseVisualStyleBackColor = false;
            this.btn_Esq_Senha.Click += new System.EventHandler(this.btn_Esq_Senha_Click);
            // 
            // btn_Nv_Cadastro
            // 
            this.btn_Nv_Cadastro.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Nv_Cadastro.Location = new System.Drawing.Point(12, 34);
            this.btn_Nv_Cadastro.Name = "btn_Nv_Cadastro";
            this.btn_Nv_Cadastro.Size = new System.Drawing.Size(97, 23);
            this.btn_Nv_Cadastro.TabIndex = 0;
            this.btn_Nv_Cadastro.Text = "Novo Cadastro";
            this.btn_Nv_Cadastro.UseVisualStyleBackColor = false;
            this.btn_Nv_Cadastro.Click += new System.EventHandler(this.btn_Nv_Cadastro_Click);
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.tbox_Senha_Login);
            this.pnl_Detalhe.Controls.Add(this.btn_Entrar);
            this.pnl_Detalhe.Controls.Add(this.tbox_Email_Login);
            this.pnl_Detalhe.Controls.Add(this.label3);
            this.pnl_Detalhe.Controls.Add(this.label2);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(0, 73);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(368, 229);
            this.pnl_Detalhe.TabIndex = 2;
            // 
            // tbox_Senha_Login
            // 
            this.tbox_Senha_Login.Location = new System.Drawing.Point(91, 136);
            this.tbox_Senha_Login.Name = "tbox_Senha_Login";
            this.tbox_Senha_Login.Size = new System.Drawing.Size(166, 23);
            this.tbox_Senha_Login.TabIndex = 3;
            this.tbox_Senha_Login.UseSystemPasswordChar = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Entrar.Location = new System.Drawing.Point(137, 178);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrar.TabIndex = 1;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // tbox_Email_Login
            // 
            this.tbox_Email_Login.Location = new System.Drawing.Point(91, 60);
            this.tbox_Email_Login.Name = "tbox_Email_Login";
            this.tbox_Email_Login.Size = new System.Drawing.Size(166, 23);
            this.tbox_Email_Login.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 371);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Botao);
            this.Controls.Add(this.pnl_Titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Botao.ResumeLayout(false);
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Titulo;
        private Label label1;
        private Panel pnl_Botao;
        private Panel pnl_Detalhe;
        private Label label3;
        private Label label2;
        private Button btn_Esq_Senha;
        private Button btn_Nv_Cadastro;
        private TextBox tbox_Senha_Login;
        private Button btn_Entrar;
        private TextBox tbox_Email_Login;
        private CheckBox cbox_Visual;
    }
}