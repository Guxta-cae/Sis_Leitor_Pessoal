namespace Sis_Leitor_Pessoal
{
    partial class Frm_Cadastro
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
            this.pnl_Botao = new System.Windows.Forms.Panel();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.pnl_TituloC = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.tbox_Nm_Usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Senha_Usuario = new System.Windows.Forms.TextBox();
            this.tbox_Email_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Botao.SuspendLayout();
            this.pnl_TituloC.SuspendLayout();
            this.pnl_Detalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Botao
            // 
            this.pnl_Botao.BackColor = System.Drawing.Color.Thistle;
            this.pnl_Botao.Controls.Add(this.btn_Cadastrar);
            this.pnl_Botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botao.Location = new System.Drawing.Point(0, 378);
            this.pnl_Botao.Name = "pnl_Botao";
            this.pnl_Botao.Size = new System.Drawing.Size(429, 69);
            this.pnl_Botao.TabIndex = 2;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(312, 22);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(105, 35);
            this.btn_Cadastrar.TabIndex = 2;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // pnl_TituloC
            // 
            this.pnl_TituloC.BackColor = System.Drawing.Color.Thistle;
            this.pnl_TituloC.Controls.Add(this.label1);
            this.pnl_TituloC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TituloC.Location = new System.Drawing.Point(0, 0);
            this.pnl_TituloC.Name = "pnl_TituloC";
            this.pnl_TituloC.Size = new System.Drawing.Size(429, 73);
            this.pnl_TituloC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.tbox_Nm_Usuario);
            this.pnl_Detalhe.Controls.Add(this.label4);
            this.pnl_Detalhe.Controls.Add(this.tbox_Senha_Usuario);
            this.pnl_Detalhe.Controls.Add(this.tbox_Email_Usuario);
            this.pnl_Detalhe.Controls.Add(this.label3);
            this.pnl_Detalhe.Controls.Add(this.label2);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(0, 73);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(429, 305);
            this.pnl_Detalhe.TabIndex = 4;
            // 
            // tbox_Nm_Usuario
            // 
            this.tbox_Nm_Usuario.Location = new System.Drawing.Point(134, 65);
            this.tbox_Nm_Usuario.Name = "tbox_Nm_Usuario";
            this.tbox_Nm_Usuario.Size = new System.Drawing.Size(166, 23);
            this.tbox_Nm_Usuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // tbox_Senha_Usuario
            // 
            this.tbox_Senha_Usuario.Location = new System.Drawing.Point(134, 235);
            this.tbox_Senha_Usuario.Name = "tbox_Senha_Usuario";
            this.tbox_Senha_Usuario.Size = new System.Drawing.Size(166, 23);
            this.tbox_Senha_Usuario.TabIndex = 3;
            this.tbox_Senha_Usuario.UseSystemPasswordChar = true;
            // 
            // tbox_Email_Usuario
            // 
            this.tbox_Email_Usuario.Location = new System.Drawing.Point(134, 151);
            this.tbox_Email_Usuario.Name = "tbox_Email_Usuario";
            this.tbox_Email_Usuario.Size = new System.Drawing.Size(166, 23);
            this.tbox_Email_Usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(134, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 447);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_TituloC);
            this.Controls.Add(this.pnl_Botao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Botao.ResumeLayout(false);
            this.pnl_TituloC.ResumeLayout(false);
            this.pnl_TituloC.PerformLayout();
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnl_Botao;
        private Button btn_Cadastrar;
        private Panel pnl_TituloC;
        private Label label1;
        private Panel pnl_Detalhe;
        private TextBox tbox_Nm_Usuario;
        private Label label4;
        private TextBox tbox_Senha_Usuario;
        private TextBox tbox_Email_Usuario;
        private Label label3;
        private Label label2;
    }
}