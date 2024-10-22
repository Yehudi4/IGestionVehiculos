namespace IGestionVehiculos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblCapacidadCarga = new System.Windows.Forms.Label();
            this.lblCapacidadBateria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCapacidadBateria = new System.Windows.Forms.TextBox();
            this.txtCapacidadCarga = new System.Windows.Forms.TextBox();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.ClTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnArrancar = new System.Windows.Forms.Button();
            this.btnMoverse = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnCargaBateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(163, 90);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(199, 31);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Auto",
            "Auto Electrico",
            "Camion",
            "Motocicleta"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(472, 87);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(218, 39);
            this.cmbTipoVehiculo.TabIndex = 1;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(163, 172);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(86, 31);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblModelo.Location = new System.Drawing.Point(163, 258);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(103, 31);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblCapacidadCarga
            // 
            this.lblCapacidadCarga.AutoSize = true;
            this.lblCapacidadCarga.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCapacidadCarga.Location = new System.Drawing.Point(163, 448);
            this.lblCapacidadCarga.Name = "lblCapacidadCarga";
            this.lblCapacidadCarga.Size = new System.Drawing.Size(229, 31);
            this.lblCapacidadCarga.TabIndex = 4;
            this.lblCapacidadCarga.Text = "Capacidad de Carga:";
            // 
            // lblCapacidadBateria
            // 
            this.lblCapacidadBateria.AutoSize = true;
            this.lblCapacidadBateria.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCapacidadBateria.Location = new System.Drawing.Point(163, 349);
            this.lblCapacidadBateria.Name = "lblCapacidadBateria";
            this.lblCapacidadBateria.Size = new System.Drawing.Size(244, 31);
            this.lblCapacidadBateria.TabIndex = 5;
            this.lblCapacidadBateria.Text = "Capacidad de Bateria:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtMarca.Location = new System.Drawing.Point(472, 172);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(218, 38);
            this.txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtModelo.Location = new System.Drawing.Point(472, 251);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(218, 38);
            this.txtModelo.TabIndex = 7;
            // 
            // txtCapacidadBateria
            // 
            this.txtCapacidadBateria.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtCapacidadBateria.Location = new System.Drawing.Point(472, 349);
            this.txtCapacidadBateria.Name = "txtCapacidadBateria";
            this.txtCapacidadBateria.Size = new System.Drawing.Size(218, 38);
            this.txtCapacidadBateria.TabIndex = 9;
            // 
            // txtCapacidadCarga
            // 
            this.txtCapacidadCarga.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtCapacidadCarga.Location = new System.Drawing.Point(472, 448);
            this.txtCapacidadCarga.Name = "txtCapacidadCarga";
            this.txtCapacidadCarga.Size = new System.Drawing.Size(218, 38);
            this.txtCapacidadCarga.TabIndex = 10;
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClTipoVehiculo,
            this.ClMarca,
            this.ClModelo,
            this.ClBateria,
            this.ClCarga});
            this.dataGridViewVehiculos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(761, 69);
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.ReadOnly = true;
            this.dataGridViewVehiculos.RowHeadersWidth = 51;
            this.dataGridViewVehiculos.RowTemplate.Height = 24;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(711, 442);
            this.dataGridViewVehiculos.TabIndex = 11;
            // 
            // ClTipoVehiculo
            // 
            this.ClTipoVehiculo.HeaderText = "Tipo";
            this.ClTipoVehiculo.MinimumWidth = 6;
            this.ClTipoVehiculo.Name = "ClTipoVehiculo";
            this.ClTipoVehiculo.ReadOnly = true;
            this.ClTipoVehiculo.Width = 125;
            // 
            // ClMarca
            // 
            this.ClMarca.HeaderText = "Marca";
            this.ClMarca.MinimumWidth = 6;
            this.ClMarca.Name = "ClMarca";
            this.ClMarca.ReadOnly = true;
            this.ClMarca.Width = 125;
            // 
            // ClModelo
            // 
            this.ClModelo.HeaderText = "Modelo";
            this.ClModelo.MinimumWidth = 6;
            this.ClModelo.Name = "ClModelo";
            this.ClModelo.ReadOnly = true;
            this.ClModelo.Width = 125;
            // 
            // ClBateria
            // 
            this.ClBateria.HeaderText = "Bateria";
            this.ClBateria.MinimumWidth = 6;
            this.ClBateria.Name = "ClBateria";
            this.ClBateria.ReadOnly = true;
            this.ClBateria.Width = 125;
            // 
            // ClCarga
            // 
            this.ClCarga.HeaderText = "Carga";
            this.ClCarga.MinimumWidth = 6;
            this.ClCarga.Name = "ClCarga";
            this.ClCarga.ReadOnly = true;
            this.ClCarga.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(210, 597);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 56);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnArrancar
            // 
            this.btnArrancar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrancar.Location = new System.Drawing.Point(472, 597);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(139, 56);
            this.btnArrancar.TabIndex = 14;
            this.btnArrancar.Text = "Arrancar";
            this.btnArrancar.UseVisualStyleBackColor = true;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // btnMoverse
            // 
            this.btnMoverse.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverse.Location = new System.Drawing.Point(761, 597);
            this.btnMoverse.Name = "btnMoverse";
            this.btnMoverse.Size = new System.Drawing.Size(139, 56);
            this.btnMoverse.TabIndex = 15;
            this.btnMoverse.Text = "Moverse";
            this.btnMoverse.UseVisualStyleBackColor = true;
            this.btnMoverse.Click += new System.EventHandler(this.btnMoverse_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(1020, 597);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(139, 56);
            this.btnDetener.TabIndex = 17;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnCargaBateria
            // 
            this.btnCargaBateria.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaBateria.Location = new System.Drawing.Point(1283, 597);
            this.btnCargaBateria.Name = "btnCargaBateria";
            this.btnCargaBateria.Size = new System.Drawing.Size(171, 56);
            this.btnCargaBateria.TabIndex = 19;
            this.btnCargaBateria.Text = "CargarBateria";
            this.btnCargaBateria.UseVisualStyleBackColor = true;
            this.btnCargaBateria.Click += new System.EventHandler(this.btnCargaBateria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 739);
            this.Controls.Add(this.btnCargaBateria);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnMoverse);
            this.Controls.Add(this.btnArrancar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewVehiculos);
            this.Controls.Add(this.txtCapacidadCarga);
            this.Controls.Add(this.txtCapacidadBateria);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblCapacidadBateria);
            this.Controls.Add(this.lblCapacidadCarga);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCapacidadCarga;
        private System.Windows.Forms.Label lblCapacidadBateria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCapacidadBateria;
        private System.Windows.Forms.TextBox txtCapacidadCarga;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCarga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.Button btnMoverse;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnCargaBateria;
    }
}

