namespace UC11_LOGIN_BDD
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
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.labelERROLOGIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(77, 76);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(144, 20);
            this.textBoxUSUARIO.TabIndex = 0;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(77, 151);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(144, 20);
            this.textBoxSENHA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonENTRAR.FlatAppearance.BorderSize = 0;
            this.buttonENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENTRAR.ForeColor = System.Drawing.Color.Black;
            this.buttonENTRAR.Image = global::UC11_LOGIN_BDD.Properties.Resources.btn_entrar;
            this.buttonENTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonENTRAR.Location = new System.Drawing.Point(47, 224);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(92, 30);
            this.buttonENTRAR.TabIndex = 4;
            this.buttonENTRAR.Text = "          Entrar";
            this.buttonENTRAR.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonENTRAR.UseVisualStyleBackColor = false;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLIMPAR.FlatAppearance.BorderSize = 0;
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLIMPAR.Image = global::UC11_LOGIN_BDD.Properties.Resources.limpar_bdd;
            this.buttonLIMPAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLIMPAR.Location = new System.Drawing.Point(180, 224);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(100, 30);
            this.buttonLIMPAR.TabIndex = 5;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.UseVisualStyleBackColor = false;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCADASTRAR.FlatAppearance.BorderSize = 0;
            this.buttonCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.Location = new System.Drawing.Point(110, 304);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(84, 23);
            this.buttonCADASTRAR.TabIndex = 6;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = false;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // labelERROLOGIN
            // 
            this.labelERROLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelERROLOGIN.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelERROLOGIN.ForeColor = System.Drawing.Color.Red;
            this.labelERROLOGIN.Location = new System.Drawing.Point(38, 186);
            this.labelERROLOGIN.Name = "labelERROLOGIN";
            this.labelERROLOGIN.Size = new System.Drawing.Size(242, 24);
            this.labelERROLOGIN.TabIndex = 7;
            this.labelERROLOGIN.Text = "Usuário e /ou Senha incorretos.";
            this.labelERROLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC11_LOGIN_BDD.Properties.Resources.bg_abstrato_cinza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.labelERROLOGIN);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonENTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Label labelERROLOGIN;
    }
}

