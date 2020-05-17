namespace cadastro
{
    partial class frm_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cadastro));
            this.lbl_nometela = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.btn_Concluido = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nometela
            // 
            this.lbl_nometela.AutoSize = true;
            this.lbl_nometela.ForeColor = System.Drawing.Color.Green;
            this.lbl_nometela.Location = new System.Drawing.Point(63, 248);
            this.lbl_nometela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nometela.Name = "lbl_nometela";
            this.lbl_nometela.Size = new System.Drawing.Size(0, 19);
            this.lbl_nometela.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.ForeColor = System.Drawing.Color.Green;
            this.lbl_nome.Location = new System.Drawing.Point(19, 62);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(58, 19);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.ForeColor = System.Drawing.Color.Green;
            this.lbl_sobrenome.Location = new System.Drawing.Point(18, 107);
            this.lbl_sobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(99, 19);
            this.lbl_sobrenome.TabIndex = 2;
            this.lbl_sobrenome.Text = "Sobrenome:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.ForeColor = System.Drawing.Color.Green;
            this.lbl_idade.Location = new System.Drawing.Point(19, 151);
            this.lbl_idade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(61, 19);
            this.lbl_idade.TabIndex = 3;
            this.lbl_idade.Text = "Idade: ";
            // 
            // btn_Concluido
            // 
            this.btn_Concluido.BackColor = System.Drawing.Color.Green;
            this.btn_Concluido.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Concluido.ForeColor = System.Drawing.Color.White;
            this.btn_Concluido.Location = new System.Drawing.Point(23, 193);
            this.btn_Concluido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Concluido.Name = "btn_Concluido";
            this.btn_Concluido.Size = new System.Drawing.Size(75, 40);
            this.btn_Concluido.TabIndex = 3;
            this.btn_Concluido.Text = "Concluido";
            this.btn_Concluido.UseVisualStyleBackColor = false;
            this.btn_Concluido.Click += new System.EventHandler(this.btn_Concluido_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.ForeColor = System.Drawing.Color.Green;
            this.txt_nome.Location = new System.Drawing.Point(123, 51);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(148, 26);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.ForeColor = System.Drawing.Color.Green;
            this.txt_sobrenome.Location = new System.Drawing.Point(123, 96);
            this.txt_sobrenome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(148, 26);
            this.txt_sobrenome.TabIndex = 1;
            this.txt_sobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sobrenome_KeyPress);
            // 
            // txt_idade
            // 
            this.txt_idade.ForeColor = System.Drawing.Color.Green;
            this.txt_idade.Location = new System.Drawing.Point(123, 142);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idade.MaxLength = 3;
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(62, 26);
            this.txt_idade.TabIndex = 2;
            this.txt_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idade_KeyPress);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Green;
            this.btn_sair.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(193, 193);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(78, 40);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro.ForeColor = System.Drawing.Color.Green;
            this.lbl_cadastro.Location = new System.Drawing.Point(63, 9);
            this.lbl_cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(173, 21);
            this.lbl_cadastro.TabIndex = 5;
            this.lbl_cadastro.Text = "Faça seu cadastro!";
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.Green;
            this.Limpar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.ForeColor = System.Drawing.Color.White;
            this.Limpar.Location = new System.Drawing.Point(111, 193);
            this.Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(74, 40);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // frm_Cadastro
            // 
            this.AcceptButton = this.btn_Concluido;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 287);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.lbl_cadastro);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_Concluido);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_nometela);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nometela;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Button btn_Concluido;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_cadastro;
        private System.Windows.Forms.Button Limpar;
    }
}

