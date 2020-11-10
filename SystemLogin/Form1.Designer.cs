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
            this.pnl_photo = new System.Windows.Forms.Panel();
            this.pb_imge = new System.Windows.Forms.PictureBox();
            this.pnl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_info
            // 
            this.pnl_info.Controls.Add(this.pb_imge);
            this.pnl_info.Location = new System.Drawing.Point(40, 40);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(640, 330);
            this.pnl_info.TabIndex = 0;
            // 
            // pnl_photo
            // 
            this.pnl_photo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_photo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_photo.Location = new System.Drawing.Point(0, 0);
            this.pnl_photo.Name = "pnl_photo";
            this.pnl_photo.Size = new System.Drawing.Size(727, 157);
            this.pnl_photo.TabIndex = 1;
            // 
            // pb_imge
            // 
            this.pb_imge.Image = global::SystemLogin.Properties.Resources.user;
            this.pb_imge.Location = new System.Drawing.Point(274, 30);
            this.pb_imge.Name = "pb_imge";
            this.pb_imge.Size = new System.Drawing.Size(100, 100);
            this.pb_imge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imge.TabIndex = 0;
            this.pb_imge.TabStop = false;
            // 
            // F_SystemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 397);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.pnl_photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_SystemLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.pnl_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Panel pnl_photo;
        private System.Windows.Forms.PictureBox pb_imge;
    }
}

