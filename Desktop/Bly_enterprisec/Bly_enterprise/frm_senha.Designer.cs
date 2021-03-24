namespace Bly_enterprise
{
    partial class frm_senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_senha));
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_NewSenha = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.txt_ConfirmSenha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_SenhaAntiga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(315, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 6;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 13;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_NewSenha
            // 
            this.txt_NewSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.txt_NewSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NewSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewSenha.ForeColor = System.Drawing.Color.White;
            this.txt_NewSenha.Location = new System.Drawing.Point(72, 231);
            this.txt_NewSenha.Multiline = true;
            this.txt_NewSenha.Name = "txt_NewSenha";
            this.txt_NewSenha.PasswordChar = '*';
            this.txt_NewSenha.Size = new System.Drawing.Size(220, 30);
            this.txt_NewSenha.TabIndex = 12;
            this.txt_NewSenha.Text = "Nova senha";
            this.txt_NewSenha.UseSystemPasswordChar = true;
            this.txt_NewSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_NewSenha_MouseClick);
            this.txt_NewSenha.TextChanged += new System.EventHandler(this.txt_NewSenha_TextChanged);
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.btn_acessar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acessar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acessar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_acessar.Location = new System.Drawing.Point(72, 342);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(220, 37);
            this.btn_acessar.TabIndex = 17;
            this.btn_acessar.Text = "SALVAR";
            this.btn_acessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // txt_ConfirmSenha
            // 
            this.txt_ConfirmSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.txt_ConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmSenha.ForeColor = System.Drawing.Color.White;
            this.txt_ConfirmSenha.Location = new System.Drawing.Point(72, 279);
            this.txt_ConfirmSenha.Multiline = true;
            this.txt_ConfirmSenha.Name = "txt_ConfirmSenha";
            this.txt_ConfirmSenha.PasswordChar = '*';
            this.txt_ConfirmSenha.Size = new System.Drawing.Size(220, 30);
            this.txt_ConfirmSenha.TabIndex = 18;
            this.txt_ConfirmSenha.Text = "Confirmar nova senha";
            this.txt_ConfirmSenha.UseSystemPasswordChar = true;
            this.txt_ConfirmSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_ConfirmSenha_MouseClick);
            this.txt_ConfirmSenha.TextChanged += new System.EventHandler(this.txt_ConfirmSenha_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(29, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 19;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(29, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 20;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txt_SenhaAntiga
            // 
            this.txt_SenhaAntiga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.txt_SenhaAntiga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SenhaAntiga.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaAntiga.ForeColor = System.Drawing.Color.White;
            this.txt_SenhaAntiga.Location = new System.Drawing.Point(72, 185);
            this.txt_SenhaAntiga.Multiline = true;
            this.txt_SenhaAntiga.Name = "txt_SenhaAntiga";
            this.txt_SenhaAntiga.PasswordChar = '*';
            this.txt_SenhaAntiga.Size = new System.Drawing.Size(220, 30);
            this.txt_SenhaAntiga.TabIndex = 22;
            this.txt_SenhaAntiga.Text = "Digite sua senha atual";
            this.txt_SenhaAntiga.UseSystemPasswordChar = true;
            this.txt_SenhaAntiga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_SenhaAntiga_MouseClick_1);
            // 
            // frm_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(345, 513);
            this.Controls.Add(this.txt_SenhaAntiga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_ConfirmSenha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NewSenha);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_senha";
            this.Load += new System.EventHandler(this.frm_senha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_NewSenha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.TextBox txt_ConfirmSenha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_SenhaAntiga;
    }
}