namespace Sis_Leitor_Pessoal
{
    partial class Frm_Recupera_Senha
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
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_redefinir = new System.Windows.Forms.Button();
            this.tbox_NSenha_Rec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Cod_Rec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbox_Email_Rec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Titulo.SuspendLayout();
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
            this.pnl_Titulo.Size = new System.Drawing.Size(456, 73);
            this.pnl_Titulo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Senha";
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.btn_verificar);
            this.pnl_Detalhe.Controls.Add(this.btn_redefinir);
            this.pnl_Detalhe.Controls.Add(this.tbox_NSenha_Rec);
            this.pnl_Detalhe.Controls.Add(this.label4);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Rec);
            this.pnl_Detalhe.Controls.Add(this.label3);
            this.pnl_Detalhe.Controls.Add(this.btn_enviar);
            this.pnl_Detalhe.Controls.Add(this.panel1);
            this.pnl_Detalhe.Controls.Add(this.tbox_Email_Rec);
            this.pnl_Detalhe.Controls.Add(this.label2);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(0, 73);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(456, 366);
            this.pnl_Detalhe.TabIndex = 5;
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Thistle;
            this.btn_verificar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verificar.Location = new System.Drawing.Point(315, 128);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(65, 23);
            this.btn_verificar.TabIndex = 12;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // btn_redefinir
            // 
            this.btn_redefinir.BackColor = System.Drawing.Color.Thistle;
            this.btn_redefinir.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_redefinir.Location = new System.Drawing.Point(315, 213);
            this.btn_redefinir.Name = "btn_redefinir";
            this.btn_redefinir.Size = new System.Drawing.Size(65, 23);
            this.btn_redefinir.TabIndex = 11;
            this.btn_redefinir.Text = "Redefinir ";
            this.btn_redefinir.UseVisualStyleBackColor = false;
            this.btn_redefinir.Click += new System.EventHandler(this.btn_Redefinir_Click);
            // 
            // tbox_NSenha_Rec
            // 
            this.tbox_NSenha_Rec.Location = new System.Drawing.Point(134, 213);
            this.tbox_NSenha_Rec.Name = "tbox_NSenha_Rec";
            this.tbox_NSenha_Rec.Size = new System.Drawing.Size(166, 23);
            this.tbox_NSenha_Rec.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nova Senha:";
            // 
            // tbox_Cod_Rec
            // 
            this.tbox_Cod_Rec.Location = new System.Drawing.Point(134, 128);
            this.tbox_Cod_Rec.Name = "tbox_Cod_Rec";
            this.tbox_Cod_Rec.Size = new System.Drawing.Size(166, 23);
            this.tbox_Cod_Rec.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(134, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código:";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Thistle;
            this.btn_enviar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_enviar.Location = new System.Drawing.Point(315, 51);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(65, 23);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 69);
            this.panel1.TabIndex = 6;
            // 
            // tbox_Email_Rec
            // 
            this.tbox_Email_Rec.Location = new System.Drawing.Point(134, 51);
            this.tbox_Email_Rec.Name = "tbox_Email_Rec";
            this.tbox_Email_Rec.Size = new System.Drawing.Size(166, 23);
            this.tbox_Email_Rec.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // Frm_Recupera_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 439);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Recupera_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Titulo;
        private Label label1;
        private Panel pnl_Detalhe;
        private TextBox tbox_Email_Rec;
        private Label label2;
        private Button btn_redefinir;
        private TextBox tbox_NSenha_Rec;
        private Label label4;
        private TextBox tbox_Cod_Rec;
        private Label label3;
        private Button btn_enviar;
        private Panel panel1;
        private Button btn_verificar;
    }
}