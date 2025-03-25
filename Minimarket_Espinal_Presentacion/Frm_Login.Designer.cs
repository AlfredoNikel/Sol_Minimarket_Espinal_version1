namespace Minimarket_Espinal_Presentacion
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Pnl_Mostrar = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_login_us = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_password_us = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Pnl_Mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Mostrar
            // 
            this.Pnl_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Pnl_Mostrar.Controls.Add(this.label21);
            this.Pnl_Mostrar.Location = new System.Drawing.Point(2, 1);
            this.Pnl_Mostrar.Name = "Pnl_Mostrar";
            this.Pnl_Mostrar.Size = new System.Drawing.Size(437, 35);
            this.Pnl_Mostrar.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(138, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(144, 18);
            this.label21.TabIndex = 0;
            this.label21.Text = "Inicio de Sesión";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minimarket Espinal";
            // 
            // Txt_login_us
            // 
            this.Txt_login_us.Location = new System.Drawing.Point(116, 230);
            this.Txt_login_us.MaxLength = 20;
            this.Txt_login_us.Name = "Txt_login_us";
            this.Txt_login_us.Size = new System.Drawing.Size(211, 20);
            this.Txt_login_us.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login:(*)";
            // 
            // Txt_password_us
            // 
            this.Txt_password_us.Location = new System.Drawing.Point(116, 266);
            this.Txt_password_us.MaxLength = 20;
            this.Txt_password_us.Name = "Txt_password_us";
            this.Txt_password_us.PasswordChar = '*';
            this.Txt_password_us.Size = new System.Drawing.Size(211, 20);
            this.Txt_password_us.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:(*)";
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Iniciar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Iniciar.Image")));
            this.Btn_Iniciar.Location = new System.Drawing.Point(232, 322);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(95, 33);
            this.Btn_Iniciar.TabIndex = 16;
            this.Btn_Iniciar.Text = "Iniciar";
            this.Btn_Iniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Iniciar.UseVisualStyleBackColor = false;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Red;
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(116, 322);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(95, 33);
            this.Btn_Salir.TabIndex = 17;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(439, 412);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Iniciar);
            this.Controls.Add(this.Txt_login_us);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_password_us);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pnl_Mostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 451);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 451);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.Pnl_Mostrar.ResumeLayout(false);
            this.Pnl_Mostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Mostrar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_login_us;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_password_us;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}