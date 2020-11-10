namespace SystemLogin
{
    partial class F_SystemLogin
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
            this.pnl_info = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pnl_photo = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.pb_imge = new System.Windows.Forms.PictureBox();
            this.pnl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_info
            // 
            this.pnl_info.Controls.Add(this.btn_login);
            this.pnl_info.Controls.Add(this.tb_password);
            this.pnl_info.Controls.Add(this.tb_login);
            this.pnl_info.Controls.Add(this.label1);
            this.pnl_info.Controls.Add(this.lbl_login);
            this.pnl_info.Controls.Add(this.pb_imge);
            this.pnl_info.Location = new System.Drawing.Point(40, 56);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(640, 360);
            this.pnl_info.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(159, 264);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(324, 27);
            this.tb_password.TabIndex = 4;
            this.tb_password.Text = "12345";
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.Location = new System.Drawing.Point(159, 190);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(324, 27);
            this.tb_login.TabIndex = 3;
            this.tb_login.Enter += new System.EventHandler(this.tb_loginEnter);
            this.tb_login.Leave += new System.EventHandler(this.tb_loginExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(155, 166);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(65, 19);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Usuário";
            // 
            // pnl_photo
            // 
            this.pnl_photo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_photo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_photo.Location = new System.Drawing.Point(0, 0);
            this.pnl_photo.Name = "pnl_photo";
            this.pnl_photo.Size = new System.Drawing.Size(730, 157);
            this.pnl_photo.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.Location = new System.Drawing.Point(272, 318);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 30);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pb_imge
            // 
            this.pb_imge.Image = global::SystemLogin.Properties.Resources.user_2;
            this.pb_imge.Location = new System.Drawing.Point(259, 20);
            this.pb_imge.Name = "pb_imge";
            this.pb_imge.Size = new System.Drawing.Size(125, 125);
            this.pb_imge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imge.TabIndex = 0;
            this.pb_imge.TabStop = false;
            // 
            // F_SystemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.pnl_photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_SystemLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Panel pnl_photo;
        private System.Windows.Forms.PictureBox pb_imge;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_login;
    }
}

