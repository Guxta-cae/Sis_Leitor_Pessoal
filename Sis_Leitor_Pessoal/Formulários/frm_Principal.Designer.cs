namespace Sis_Leitor_Pessoal
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.btn_Parar = new System.Windows.Forms.Button();
            this.btn_Falar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.trb_Volume = new System.Windows.Forms.TrackBar();
            this.trb_Velocidade = new System.Windows.Forms.TrackBar();
            this.btn_Velocidade = new System.Windows.Forms.Button();
            this.btn_Volume = new System.Windows.Forms.Button();
            this.tbox_Texto = new System.Windows.Forms.TextBox();
            this.cmb_Arquivo = new System.Windows.Forms.ComboBox();
            this.btn_Arquivo = new System.Windows.Forms.Button();
            this.tbox_Arquivo = new System.Windows.Forms.TextBox();
            this.cmb_Texto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Vozes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Velocidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Parar
            // 
            this.btn_Parar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Parar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Parar.Location = new System.Drawing.Point(1001, 135);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(109, 41);
            this.btn_Parar.TabIndex = 1;
            this.btn_Parar.Text = "Parar";
            this.btn_Parar.UseVisualStyleBackColor = false;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // btn_Falar
            // 
            this.btn_Falar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Falar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Falar.Location = new System.Drawing.Point(861, 135);
            this.btn_Falar.Name = "btn_Falar";
            this.btn_Falar.Size = new System.Drawing.Size(106, 41);
            this.btn_Falar.TabIndex = 2;
            this.btn_Falar.Text = "Falar";
            this.btn_Falar.UseVisualStyleBackColor = false;
            this.btn_Falar.Click += new System.EventHandler(this.btn_Falar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Limpar.Location = new System.Drawing.Point(1151, 135);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(106, 41);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // trb_Volume
            // 
            this.trb_Volume.BackColor = System.Drawing.SystemColors.Control;
            this.trb_Volume.Location = new System.Drawing.Point(927, 50);
            this.trb_Volume.Maximum = 100;
            this.trb_Volume.Name = "trb_Volume";
            this.trb_Volume.Size = new System.Drawing.Size(351, 45);
            this.trb_Volume.TabIndex = 4;
            this.trb_Volume.Value = 70;
            // 
            // trb_Velocidade
            // 
            this.trb_Velocidade.Location = new System.Drawing.Point(927, 12);
            this.trb_Velocidade.Minimum = -10;
            this.trb_Velocidade.Name = "trb_Velocidade";
            this.trb_Velocidade.Size = new System.Drawing.Size(351, 45);
            this.trb_Velocidade.TabIndex = 5;
            // 
            // btn_Velocidade
            // 
            this.btn_Velocidade.Image = ((System.Drawing.Image)(resources.GetObject("btn_Velocidade.Image")));
            this.btn_Velocidade.Location = new System.Drawing.Point(885, 20);
            this.btn_Velocidade.Name = "btn_Velocidade";
            this.btn_Velocidade.Size = new System.Drawing.Size(36, 32);
            this.btn_Velocidade.TabIndex = 6;
            this.btn_Velocidade.UseVisualStyleBackColor = true;
            this.btn_Velocidade.Click += new System.EventHandler(this.btn_Velocidade_Click);
            // 
            // btn_Volume
            // 
            this.btn_Volume.Image = ((System.Drawing.Image)(resources.GetObject("btn_Volume.Image")));
            this.btn_Volume.Location = new System.Drawing.Point(885, 54);
            this.btn_Volume.Name = "btn_Volume";
            this.btn_Volume.Size = new System.Drawing.Size(36, 30);
            this.btn_Volume.TabIndex = 7;
            this.btn_Volume.UseVisualStyleBackColor = true;
            this.btn_Volume.Click += new System.EventHandler(this.btn_Volume_Click);
            // 
            // tbox_Texto
            // 
            this.tbox_Texto.Location = new System.Drawing.Point(-1, 205);
            this.tbox_Texto.Multiline = true;
            this.tbox_Texto.Name = "tbox_Texto";
            this.tbox_Texto.Size = new System.Drawing.Size(1279, 504);
            this.tbox_Texto.TabIndex = 8;
            this.tbox_Texto.TextChanged += new System.EventHandler(this.tbox_Texto_TextChanged);
            // 
            // cmb_Arquivo
            // 
            this.cmb_Arquivo.FormattingEnabled = true;
            this.cmb_Arquivo.Location = new System.Drawing.Point(442, 54);
            this.cmb_Arquivo.Name = "cmb_Arquivo";
            this.cmb_Arquivo.Size = new System.Drawing.Size(257, 23);
            this.cmb_Arquivo.TabIndex = 9;
            this.cmb_Arquivo.SelectedIndexChanged += new System.EventHandler(this.cmb_Arquivo_SelectedIndexChanged);
            // 
            // btn_Arquivo
            // 
            this.btn_Arquivo.BackColor = System.Drawing.Color.Thistle;
            this.btn_Arquivo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Arquivo.Location = new System.Drawing.Point(275, 51);
            this.btn_Arquivo.Name = "btn_Arquivo";
            this.btn_Arquivo.Size = new System.Drawing.Size(85, 36);
            this.btn_Arquivo.TabIndex = 10;
            this.btn_Arquivo.Text = "Salvar";
            this.btn_Arquivo.UseVisualStyleBackColor = false;
            this.btn_Arquivo.Click += new System.EventHandler(this.btn_Arquivo_Click);
            // 
            // tbox_Arquivo
            // 
            this.tbox_Arquivo.Location = new System.Drawing.Point(12, 59);
            this.tbox_Arquivo.Name = "tbox_Arquivo";
            this.tbox_Arquivo.Size = new System.Drawing.Size(257, 23);
            this.tbox_Arquivo.TabIndex = 11;
            // 
            // cmb_Texto
            // 
            this.cmb_Texto.FormattingEnabled = true;
            this.cmb_Texto.Location = new System.Drawing.Point(12, 146);
            this.cmb_Texto.Name = "cmb_Texto";
            this.cmb_Texto.Size = new System.Drawing.Size(257, 23);
            this.cmb_Texto.TabIndex = 12;
            this.cmb_Texto.SelectedIndexChanged += new System.EventHandler(this.cmb_Texto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Arquivos salvos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(442, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Textos salvos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salvar caminho do arquivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(442, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vozes salvas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmb_Vozes
            // 
            this.cmb_Vozes.FormattingEnabled = true;
            this.cmb_Vozes.Location = new System.Drawing.Point(440, 146);
            this.cmb_Vozes.Name = "cmb_Vozes";
            this.cmb_Vozes.Size = new System.Drawing.Size(259, 23);
            this.cmb_Vozes.TabIndex = 16;
            this.cmb_Vozes.SelectedIndexChanged += new System.EventHandler(this.cmb_Vozes_SelectedIndexChanged);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 706);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Vozes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Texto);
            this.Controls.Add(this.tbox_Arquivo);
            this.Controls.Add(this.btn_Arquivo);
            this.Controls.Add(this.cmb_Arquivo);
            this.Controls.Add(this.tbox_Texto);
            this.Controls.Add(this.btn_Volume);
            this.Controls.Add(this.btn_Velocidade);
            this.Controls.Add(this.trb_Velocidade);
            this.Controls.Add(this.trb_Volume);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Falar);
            this.Controls.Add(this.btn_Parar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Velocidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Parar;
        private Button btn_Falar;
        private Button btn_Limpar;
        private TrackBar trb_Volume;
        private TrackBar trb_Velocidade;
        private Button btn_Velocidade;
        private Button btn_Volume;
        private TextBox tbox_Texto;
        private ComboBox cmb_Arquivo;
        private Button btn_Arquivo;
        private TextBox tbox_Arquivo;
        private ComboBox cmb_Texto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmb_Vozes;
    }
}