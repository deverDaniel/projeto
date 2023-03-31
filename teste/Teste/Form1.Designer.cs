namespace Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTcod = new System.Windows.Forms.TextBox();
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.TXTfone = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.combo_perfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_view)).BeginInit();
            this.SuspendLayout();
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(100, 40);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(25, 13);
            this.cod.TabIndex = 0;
            this.cod.Text = "cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "usuario";
            // 
            // TXTcod
            // 
            this.TXTcod.Location = new System.Drawing.Point(131, 37);
            this.TXTcod.Name = "TXTcod";
            this.TXTcod.Size = new System.Drawing.Size(100, 20);
            this.TXTcod.TabIndex = 3;
            // 
            // TXTusuario
            // 
            this.TXTusuario.Location = new System.Drawing.Point(131, 61);
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(100, 20);
            this.TXTusuario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nome";
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(131, 83);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(100, 20);
            this.TXTnome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "fone";
            // 
            // TXTemail
            // 
            this.TXTemail.Location = new System.Drawing.Point(131, 111);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(100, 20);
            this.TXTemail.TabIndex = 9;
            // 
            // TXTfone
            // 
            this.TXTfone.Location = new System.Drawing.Point(128, 137);
            this.TXTfone.Name = "TXTfone";
            this.TXTfone.Size = new System.Drawing.Size(100, 20);
            this.TXTfone.TabIndex = 10;
            // 
            // Cadastrar
            // 
            this.Cadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cadastrar.Location = new System.Drawing.Point(87, 180);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 11;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(198, 180);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(329, 179);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 13;
            this.btn_alterar.Text = "alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // combo_perfil
            // 
            this.combo_perfil.FormattingEnabled = true;
            this.combo_perfil.Location = new System.Drawing.Point(344, 40);
            this.combo_perfil.Name = "combo_perfil";
            this.combo_perfil.Size = new System.Drawing.Size(121, 21);
            this.combo_perfil.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "perfil";
            // 
            // dt_view
            // 
            this.dt_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_view.Location = new System.Drawing.Point(499, 37);
            this.dt_view.Name = "dt_view";
            this.dt_view.Size = new System.Drawing.Size(240, 150);
            this.dt_view.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_view);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_perfil);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.TXTfone);
            this.Controls.Add(this.TXTemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTusuario);
            this.Controls.Add(this.TXTcod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.Label label2;
    //    private System.Windows.Forms.Button BTNCadastrar;
        private System.Windows.Forms.TextBox TXTcod;
        private System.Windows.Forms.TextBox TXTusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.TextBox TXTfone;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.ComboBox combo_perfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_view;
    }
}

