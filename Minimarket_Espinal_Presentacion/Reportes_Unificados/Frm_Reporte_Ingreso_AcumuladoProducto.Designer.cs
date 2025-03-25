namespace Minimarket_Espinal_Presentacion.Reportes_Unificados
{
    partial class Frm_Reporte_Ingreso_AcumuladoProducto
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
            this.Btn_vistaprevia = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_Fecha_fine = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dp_Fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btn_vistaprevia
            // 
            this.Btn_vistaprevia.BackColor = System.Drawing.Color.Green;
            this.Btn_vistaprevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_vistaprevia.ForeColor = System.Drawing.Color.White;
            this.Btn_vistaprevia.Location = new System.Drawing.Point(191, 39);
            this.Btn_vistaprevia.Name = "Btn_vistaprevia";
            this.Btn_vistaprevia.Size = new System.Drawing.Size(75, 23);
            this.Btn_vistaprevia.TabIndex = 12;
            this.Btn_vistaprevia.Text = "Vista previa";
            this.Btn_vistaprevia.UseVisualStyleBackColor = false;
            this.Btn_vistaprevia.Click += new System.EventHandler(this.Btn_vistaprevia_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Red;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.White;
            this.Btn_salir.Location = new System.Drawing.Point(191, 96);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_salir.TabIndex = 11;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha fin:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dp_Fecha_fine
            // 
            this.Dp_Fecha_fine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_Fecha_fine.Location = new System.Drawing.Point(80, 96);
            this.Dp_Fecha_fine.Name = "Dp_Fecha_fine";
            this.Dp_Fecha_fine.Size = new System.Drawing.Size(79, 20);
            this.Dp_Fecha_fine.TabIndex = 9;
            this.Dp_Fecha_fine.ValueChanged += new System.EventHandler(this.Dp_Fecha_fine_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha inicio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dp_Fecha_ini
            // 
            this.Dp_Fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_Fecha_ini.Location = new System.Drawing.Point(80, 42);
            this.Dp_Fecha_ini.Name = "Dp_Fecha_ini";
            this.Dp_Fecha_ini.Size = new System.Drawing.Size(79, 20);
            this.Dp_Fecha_ini.TabIndex = 7;
            this.Dp_Fecha_ini.ValueChanged += new System.EventHandler(this.Dp_Fecha_ini_ValueChanged);
            // 
            // Frm_Reporte_Ingreso_AcumuladoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 185);
            this.Controls.Add(this.Btn_vistaprevia);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dp_Fecha_fine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dp_Fecha_ini);
            this.Name = "Frm_Reporte_Ingreso_AcumuladoProducto";
            this.Text = "REPORTE DE  INGRESO ACUMULADO POR PRODUCTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_vistaprevia;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_Fecha_fine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dp_Fecha_ini;
    }
}