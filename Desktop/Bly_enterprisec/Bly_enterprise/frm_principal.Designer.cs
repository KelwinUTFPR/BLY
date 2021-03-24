namespace Bly_enterprise
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Mapa = new System.Windows.Forms.Button();
            this.btn_Conta = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.telaConsultaRota1 = new Bly_enterprise.TelaConsultaRota();
            this.telaConsultaUsuario1 = new Bly_enterprise.TelaConsultaUsuario();
            this.telaLoginDel1 = new Bly_enterprise.TelaLoginDel();
            this.telaLoginAlter1 = new Bly_enterprise.TelaLoginAlter();
            this.telaLoginCad1 = new Bly_enterprise.TelaLoginCad();
            this.telaSaldoDel1 = new Bly_enterprise.TelaSaldoDel();
            this.telaSaldoAlter1 = new Bly_enterprise.TelaSaldoAlter();
            this.telaSaldoCad1 = new Bly_enterprise.TelaSaldoCad();
            this.telaRotDel1 = new Bly_enterprise.TelaRotDel();
            this.telaRotAlter1 = new Bly_enterprise.TelaRotAlter();
            this.telaRotCad1 = new Bly_enterprise.TelaRotCad();
            this.telaBusDel1 = new Bly_enterprise.TelaBusDel();
            this.telaBusAlter1 = new Bly_enterprise.TelaBusAlter();
            this.telaBusCad1 = new Bly_enterprise.TelaBusCad();
            this.telaUsuarioDel1 = new Bly_enterprise.TelaUsuarioDel();
            this.telaUsuarioCad1 = new Bly_enterprise.TelaUsuarioCad();
            this.telaUsuarioAlter1 = new Bly_enterprise.TelaUsuarioAlter();
            this.telaMapaControl1 = new Bly_enterprise.TelaMapaControl();
            this.telaCadastroControl1 = new Bly_enterprise.TelaCadastroControl();
            this.telaHomeControl1 = new Bly_enterprise.TelaHomeControl();
            this.telaContaControl1 = new Bly_enterprise.TelaContaControl();
            this.telaConsultarSaldo1 = new Bly_enterprise.TelaConsultarSaldo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Mapa);
            this.panel1.Controls.Add(this.btn_Conta);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 558);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SidePanel.Location = new System.Drawing.Point(1, 56);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "      Sair";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.FlatAppearance.BorderSize = 0;
            this.btn_Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consulta.ForeColor = System.Drawing.Color.White;
            this.btn_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consulta.Image")));
            this.btn_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consulta.Location = new System.Drawing.Point(12, 176);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(165, 54);
            this.btn_Consulta.TabIndex = 3;
            this.btn_Consulta.Text = "      Consulta";
            this.btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Mapa
            // 
            this.btn_Mapa.FlatAppearance.BorderSize = 0;
            this.btn_Mapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mapa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mapa.ForeColor = System.Drawing.Color.White;
            this.btn_Mapa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mapa.Image")));
            this.btn_Mapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mapa.Location = new System.Drawing.Point(12, 116);
            this.btn_Mapa.Name = "btn_Mapa";
            this.btn_Mapa.Size = new System.Drawing.Size(165, 54);
            this.btn_Mapa.TabIndex = 2;
            this.btn_Mapa.Text = "      Mapa";
            this.btn_Mapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Mapa.UseVisualStyleBackColor = true;
            this.btn_Mapa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Conta
            // 
            this.btn_Conta.FlatAppearance.BorderSize = 0;
            this.btn_Conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conta.ForeColor = System.Drawing.Color.White;
            this.btn_Conta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Conta.Image")));
            this.btn_Conta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Conta.Location = new System.Drawing.Point(12, 236);
            this.btn_Conta.Name = "btn_Conta";
            this.btn_Conta.Size = new System.Drawing.Size(165, 54);
            this.btn_Conta.TabIndex = 1;
            this.btn_Conta.Text = "      Conta";
            this.btn_Conta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Conta.UseVisualStyleBackColor = true;
            this.btn_Conta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(12, 56);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(165, 54);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "      Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(177, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 10);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(912, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 4;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(878, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 28);
            this.button6.TabIndex = 5;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(844, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 6;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = ": suportebly@gmail.com";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(526, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 28);
            this.button1.TabIndex = 12;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // telaConsultaRota1
            // 
            this.telaConsultaRota1.Location = new System.Drawing.Point(177, 58);
            this.telaConsultaRota1.Name = "telaConsultaRota1";
            this.telaConsultaRota1.Size = new System.Drawing.Size(792, 500);
            this.telaConsultaRota1.TabIndex = 33;
            // 
            // telaConsultaUsuario1
            // 
            this.telaConsultaUsuario1.Location = new System.Drawing.Point(177, 58);
            this.telaConsultaUsuario1.Name = "telaConsultaUsuario1";
            this.telaConsultaUsuario1.Size = new System.Drawing.Size(792, 500);
            this.telaConsultaUsuario1.TabIndex = 32;
            // 
            // telaLoginDel1
            // 
            this.telaLoginDel1.Location = new System.Drawing.Point(177, 58);
            this.telaLoginDel1.Name = "telaLoginDel1";
            this.telaLoginDel1.Size = new System.Drawing.Size(792, 500);
            this.telaLoginDel1.TabIndex = 31;
            // 
            // telaLoginAlter1
            // 
            this.telaLoginAlter1.Location = new System.Drawing.Point(177, 58);
            this.telaLoginAlter1.Name = "telaLoginAlter1";
            this.telaLoginAlter1.Size = new System.Drawing.Size(792, 500);
            this.telaLoginAlter1.TabIndex = 30;
            // 
            // telaLoginCad1
            // 
            this.telaLoginCad1.Location = new System.Drawing.Point(177, 58);
            this.telaLoginCad1.Name = "telaLoginCad1";
            this.telaLoginCad1.Size = new System.Drawing.Size(792, 500);
            this.telaLoginCad1.TabIndex = 29;
            // 
            // telaSaldoDel1
            // 
            this.telaSaldoDel1.Location = new System.Drawing.Point(177, 58);
            this.telaSaldoDel1.Name = "telaSaldoDel1";
            this.telaSaldoDel1.Size = new System.Drawing.Size(792, 500);
            this.telaSaldoDel1.TabIndex = 28;
            // 
            // telaSaldoAlter1
            // 
            this.telaSaldoAlter1.Location = new System.Drawing.Point(177, 58);
            this.telaSaldoAlter1.Name = "telaSaldoAlter1";
            this.telaSaldoAlter1.Size = new System.Drawing.Size(792, 500);
            this.telaSaldoAlter1.TabIndex = 27;
            // 
            // telaSaldoCad1
            // 
            this.telaSaldoCad1.Location = new System.Drawing.Point(177, 58);
            this.telaSaldoCad1.Name = "telaSaldoCad1";
            this.telaSaldoCad1.Size = new System.Drawing.Size(792, 500);
            this.telaSaldoCad1.TabIndex = 26;
            // 
            // telaRotDel1
            // 
            this.telaRotDel1.Location = new System.Drawing.Point(177, 58);
            this.telaRotDel1.Name = "telaRotDel1";
            this.telaRotDel1.Size = new System.Drawing.Size(792, 500);
            this.telaRotDel1.TabIndex = 25;
            // 
            // telaRotAlter1
            // 
            this.telaRotAlter1.Location = new System.Drawing.Point(177, 58);
            this.telaRotAlter1.Name = "telaRotAlter1";
            this.telaRotAlter1.Size = new System.Drawing.Size(792, 500);
            this.telaRotAlter1.TabIndex = 24;
            // 
            // telaRotCad1
            // 
            this.telaRotCad1.Location = new System.Drawing.Point(177, 58);
            this.telaRotCad1.Name = "telaRotCad1";
            this.telaRotCad1.Size = new System.Drawing.Size(792, 500);
            this.telaRotCad1.TabIndex = 23;
            // 
            // telaBusDel1
            // 
            this.telaBusDel1.Location = new System.Drawing.Point(177, 58);
            this.telaBusDel1.Name = "telaBusDel1";
            this.telaBusDel1.Size = new System.Drawing.Size(792, 500);
            this.telaBusDel1.TabIndex = 22;
            // 
            // telaBusAlter1
            // 
            this.telaBusAlter1.Location = new System.Drawing.Point(177, 58);
            this.telaBusAlter1.Name = "telaBusAlter1";
            this.telaBusAlter1.Size = new System.Drawing.Size(792, 500);
            this.telaBusAlter1.TabIndex = 21;
            // 
            // telaBusCad1
            // 
            this.telaBusCad1.Location = new System.Drawing.Point(177, 58);
            this.telaBusCad1.Name = "telaBusCad1";
            this.telaBusCad1.Size = new System.Drawing.Size(792, 500);
            this.telaBusCad1.TabIndex = 20;
            // 
            // telaUsuarioDel1
            // 
            this.telaUsuarioDel1.Location = new System.Drawing.Point(177, 58);
            this.telaUsuarioDel1.Name = "telaUsuarioDel1";
            this.telaUsuarioDel1.Size = new System.Drawing.Size(792, 500);
            this.telaUsuarioDel1.TabIndex = 19;
            // 
            // telaUsuarioCad1
            // 
            this.telaUsuarioCad1.Location = new System.Drawing.Point(177, 58);
            this.telaUsuarioCad1.Name = "telaUsuarioCad1";
            this.telaUsuarioCad1.Size = new System.Drawing.Size(792, 500);
            this.telaUsuarioCad1.TabIndex = 18;
            // 
            // telaUsuarioAlter1
            // 
            this.telaUsuarioAlter1.Location = new System.Drawing.Point(177, 58);
            this.telaUsuarioAlter1.Name = "telaUsuarioAlter1";
            this.telaUsuarioAlter1.Size = new System.Drawing.Size(792, 500);
            this.telaUsuarioAlter1.TabIndex = 17;
            // 
            // telaMapaControl1
            // 
            this.telaMapaControl1.Location = new System.Drawing.Point(177, 68);
            this.telaMapaControl1.Name = "telaMapaControl1";
            this.telaMapaControl1.Size = new System.Drawing.Size(792, 500);
            this.telaMapaControl1.TabIndex = 16;
            // 
            // telaCadastroControl1
            // 
            this.telaCadastroControl1.Location = new System.Drawing.Point(177, 58);
            this.telaCadastroControl1.Name = "telaCadastroControl1";
            this.telaCadastroControl1.Size = new System.Drawing.Size(792, 500);
            this.telaCadastroControl1.TabIndex = 15;
            this.telaCadastroControl1.Load += new System.EventHandler(this.telaCadastroControl1_Load);
            // 
            // telaHomeControl1
            // 
            this.telaHomeControl1.Location = new System.Drawing.Point(177, 58);
            this.telaHomeControl1.Name = "telaHomeControl1";
            this.telaHomeControl1.Size = new System.Drawing.Size(792, 500);
            this.telaHomeControl1.TabIndex = 14;
            this.telaHomeControl1.Load += new System.EventHandler(this.telaHomeControl1_Load);
            // 
            // telaContaControl1
            // 
            this.telaContaControl1.Location = new System.Drawing.Point(177, 58);
            this.telaContaControl1.Name = "telaContaControl1";
            this.telaContaControl1.Size = new System.Drawing.Size(792, 500);
            this.telaContaControl1.TabIndex = 13;
            // 
            // telaConsultarSaldo1
            // 
            this.telaConsultarSaldo1.Location = new System.Drawing.Point(177, 58);
            this.telaConsultarSaldo1.Name = "telaConsultarSaldo1";
            this.telaConsultarSaldo1.Size = new System.Drawing.Size(792, 500);
            this.telaConsultarSaldo1.TabIndex = 34;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 558);
            this.Controls.Add(this.telaConsultarSaldo1);
            this.Controls.Add(this.telaConsultaRota1);
            this.Controls.Add(this.telaConsultaUsuario1);
            this.Controls.Add(this.telaLoginDel1);
            this.Controls.Add(this.telaLoginAlter1);
            this.Controls.Add(this.telaLoginCad1);
            this.Controls.Add(this.telaSaldoDel1);
            this.Controls.Add(this.telaSaldoAlter1);
            this.Controls.Add(this.telaSaldoCad1);
            this.Controls.Add(this.telaRotDel1);
            this.Controls.Add(this.telaRotAlter1);
            this.Controls.Add(this.telaRotCad1);
            this.Controls.Add(this.telaBusDel1);
            this.Controls.Add(this.telaBusAlter1);
            this.Controls.Add(this.telaBusCad1);
            this.Controls.Add(this.telaUsuarioDel1);
            this.Controls.Add(this.telaUsuarioCad1);
            this.Controls.Add(this.telaUsuarioAlter1);
            this.Controls.Add(this.telaMapaControl1);
            this.Controls.Add(this.telaCadastroControl1);
            this.Controls.Add(this.telaHomeControl1);
            this.Controls.Add(this.telaContaControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Conta;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Mapa;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TelaContaControl telaContaControl1;
        private TelaHomeControl telaHomeControl1;
        private TelaCadastroControl telaCadastroControl1;
        private TelaMapaControl telaMapaControl1;
        private System.Windows.Forms.Timer timer1;
        private TelaUsuarioAlter telaUsuarioAlter1;
        private TelaUsuarioCad telaUsuarioCad1;
        private TelaUsuarioDel telaUsuarioDel1;
        private TelaBusCad telaBusCad1;
        private TelaBusAlter telaBusAlter1;
        private TelaBusDel telaBusDel1;
        private TelaRotCad telaRotCad1;
        private TelaRotAlter telaRotAlter1;
        private TelaRotDel telaRotDel1;
        private TelaSaldoCad telaSaldoCad1;
        private TelaSaldoAlter telaSaldoAlter1;
        private TelaSaldoDel telaSaldoDel1;
        private TelaLoginCad telaLoginCad1;
        private TelaLoginAlter telaLoginAlter1;
        private TelaLoginDel telaLoginDel1;
        private TelaConsultaUsuario telaConsultaUsuario1;
        private TelaConsultaRota telaConsultaRota1;
        private TelaConsultarSaldo telaConsultarSaldo1;
    }
}