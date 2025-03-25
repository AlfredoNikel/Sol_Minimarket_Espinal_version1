namespace Minimarket_Espinal_Presentacion
{
    partial class Frm_Almacenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Almacenes));
            this.Tbp_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_principal = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_descripcion_al = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Pnl_Mostrar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbp_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_Mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbp_principal
            // 
            this.Tbp_principal.Controls.Add(this.tabPage1);
            this.Tbp_principal.Controls.Add(this.tabPage2);
            this.Tbp_principal.Location = new System.Drawing.Point(12, 44);
            this.Tbp_principal.Name = "Tbp_principal";
            this.Tbp_principal.SelectedIndex = 0;
            this.Tbp_principal.Size = new System.Drawing.Size(992, 280);
            this.Tbp_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_principal);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.modif_Click);
            // 
            // Dgv_principal
            // 
            this.Dgv_principal.AllowUserToAddRows = false;
            this.Dgv_principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Dgv_principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_principal.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.Dgv_principal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_principal.ColumnHeadersHeight = 35;
            this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_principal.EnableHeadersVisualStyles = false;
            this.Dgv_principal.Location = new System.Drawing.Point(16, 57);
            this.Dgv_principal.Name = "Dgv_principal";
            this.Dgv_principal.ReadOnly = true;
            this.Dgv_principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_principal.Size = new System.Drawing.Size(445, 150);
            this.Dgv_principal.TabIndex = 3;
            this.Dgv_principal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_principal_CellContentClick);
            this.Dgv_principal.DoubleClick += new System.EventHandler(this.Dgv_principal_DoubleClick);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(144)))));
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(245, 28);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 2;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(66, 30);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(173, 20);
            this.Txt_buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_retornar);
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.Btn_cancelar);
            this.tabPage2.Controls.Add(this.Txt_descripcion_al);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.Green;
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar.Location = new System.Drawing.Point(302, 80);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(75, 23);
            this.Btn_retornar.TabIndex = 4;
            this.Btn_retornar.Text = "Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            this.Btn_retornar.Visible = false;
            this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(207, 80);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(111, 80);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_descripcion_al
            // 
            this.Txt_descripcion_al.Location = new System.Drawing.Point(106, 45);
            this.Txt_descripcion_al.MaxLength = 50;
            this.Txt_descripcion_al.Name = "Txt_descripcion_al";
            this.Txt_descripcion_al.ReadOnly = true;
            this.Txt_descripcion_al.Size = new System.Drawing.Size(276, 20);
            this.Txt_descripcion_al.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Almacén: (*)";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ImageKey = "IconoNuevo.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(46, 330);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(70, 57);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "IconoNuevo.png");
            this.imageList1.Images.SetKeyName(1, "Editar.png");
            this.imageList1.Images.SetKeyName(2, "Eliminar.png");
            this.imageList1.Images.SetKeyName(3, "Reporte.png");
            this.imageList1.Images.SetKeyName(4, "Salir.png");
            this.imageList1.Images.SetKeyName(5, "Reporte2.png");
            this.imageList1.Images.SetKeyName(6, "reporte3.png");
            this.imageList1.Images.SetKeyName(7, "CerrarSeccion2.png");
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.ImageKey = "reporte3.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(348, 330);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(70, 57);
            this.Btn_reporte.TabIndex = 2;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ImageKey = "Eliminar.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(248, 330);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(70, 57);
            this.Btn_eliminar.TabIndex = 3;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ImageKey = "Editar.png";
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(142, 330);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(70, 57);
            this.Btn_actualizar.TabIndex = 4;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageKey = "CerrarSeccion2.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(455, 330);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(70, 57);
            this.Btn_salir.TabIndex = 5;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Pnl_Mostrar
            // 
            this.Pnl_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(176)))), ((int)(((byte)(54)))));
            this.Pnl_Mostrar.Controls.Add(this.label3);
            this.Pnl_Mostrar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Mostrar.Name = "Pnl_Mostrar";
            this.Pnl_Mostrar.Size = new System.Drawing.Size(1031, 35);
            this.Pnl_Mostrar.TabIndex = 6;
            this.Pnl_Mostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Mostrar_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALMACENES";
            // 
            // Frm_Almacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(103)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1016, 402);
            this.Controls.Add(this.Pnl_Mostrar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Tbp_principal);
            this.Name = "Frm_Almacenes";
            this.Text = "ALMACENES";
            this.Load += new System.EventHandler(this.Frm_Almacenes_Load);
            this.Tbp_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_Mostrar.ResumeLayout(false);
            this.Pnl_Mostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbp_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_principal;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.TextBox Txt_descripcion_al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_Mostrar;
        private System.Windows.Forms.Label label3;
    }
}