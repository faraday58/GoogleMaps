namespace GoogleMaps
{
    partial class Form1
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
            this.gmcMapa = new GMap.NET.WindowsForms.GMapControl();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbLatitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvLocalizacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gmcMapa
            // 
            this.gmcMapa.Bearing = 0F;
            this.gmcMapa.CanDragMap = true;
            this.gmcMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcMapa.GrayScaleMode = false;
            this.gmcMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcMapa.LevelsKeepInMemmory = 5;
            this.gmcMapa.Location = new System.Drawing.Point(25, 44);
            this.gmcMapa.MarkersEnabled = true;
            this.gmcMapa.MaxZoom = 2;
            this.gmcMapa.MinZoom = 2;
            this.gmcMapa.MouseWheelZoomEnabled = true;
            this.gmcMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmcMapa.Name = "gmcMapa";
            this.gmcMapa.NegativeMode = false;
            this.gmcMapa.PolygonsEnabled = true;
            this.gmcMapa.RetryLoadTile = 0;
            this.gmcMapa.RoutesEnabled = true;
            this.gmcMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmcMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcMapa.ShowTileGridLines = false;
            this.gmcMapa.Size = new System.Drawing.Size(564, 371);
            this.gmcMapa.TabIndex = 0;
            this.gmcMapa.Zoom = 0D;
            this.gmcMapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmcMapa_MouseDoubleClick);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(721, 69);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(206, 20);
            this.txtbDescripcion.TabIndex = 1;
            // 
            // txtbLongitud
            // 
            this.txtbLongitud.Location = new System.Drawing.Point(721, 140);
            this.txtbLongitud.Name = "txtbLongitud";
            this.txtbLongitud.Size = new System.Drawing.Size(206, 20);
            this.txtbLongitud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitud";
            // 
            // txtbLatitud
            // 
            this.txtbLatitud.Location = new System.Drawing.Point(721, 214);
            this.txtbLatitud.Name = "txtbLatitud";
            this.txtbLatitud.Size = new System.Drawing.Size(206, 20);
            this.txtbLatitud.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latitud";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(721, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(852, 279);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvLocalizacion
            // 
            this.dgvLocalizacion.AllowUserToAddRows = false;
            this.dgvLocalizacion.AllowUserToDeleteRows = false;
            this.dgvLocalizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalizacion.Location = new System.Drawing.Point(724, 330);
            this.dgvLocalizacion.Name = "dgvLocalizacion";
            this.dgvLocalizacion.ReadOnly = true;
            this.dgvLocalizacion.Size = new System.Drawing.Size(202, 114);
            this.dgvLocalizacion.TabIndex = 4;
            this.dgvLocalizacion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistro);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.dgvLocalizacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbLatitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbLongitud);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.gmcMapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmcMapa;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbLongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbLatitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvLocalizacion;
    }
}

