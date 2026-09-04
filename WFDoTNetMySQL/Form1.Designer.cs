namespace WFDoTNetMySQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.lstContato = new System.Windows.Forms.ListView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Busca = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 74);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(154, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(92, 143);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 6;
            this.Create.Text = "Salvar";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstContato
            // 
            this.lstContato.HideSelection = false;
            this.lstContato.Location = new System.Drawing.Point(173, 57);
            this.lstContato.Name = "lstContato";
            this.lstContato.Size = new System.Drawing.Size(484, 386);
            this.lstContato.TabIndex = 7;
            this.lstContato.UseCompatibleStateImageBehavior = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(174, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(356, 30);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 9;
            this.Search.Text = "Buscar";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(174, 13);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(40, 13);
            this.Busca.TabIndex = 10;
            this.Busca.Text = "Buscar";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(11, 143);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 12;
            this.Update.Text = "Atualizar";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 447);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstContato);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ListView lstContato;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Busca;
        private System.Windows.Forms.Button Update;
    }
}

