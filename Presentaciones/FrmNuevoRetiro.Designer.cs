namespace RetiroDeMateriales.Presentaciones
{
    partial class FrmNuevoRetiro
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.txtBoxResponsable = new System.Windows.Forms.TextBox();
            this.cboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cIdMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(80, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(98, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdMaterial,
            this.cIdStock,
            this.cIdCantidad,
            this.cIdAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(8, 111);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(568, 150);
            this.dgvDetalles.TabIndex = 2;
            // 
            // txtBoxResponsable
            // 
            this.txtBoxResponsable.Location = new System.Drawing.Point(80, 54);
            this.txtBoxResponsable.Name = "txtBoxResponsable";
            this.txtBoxResponsable.Size = new System.Drawing.Size(496, 20);
            this.txtBoxResponsable.TabIndex = 3;
            // 
            // cboBoxMaterial
            // 
            this.cboBoxMaterial.FormattingEnabled = true;
            this.cboBoxMaterial.Location = new System.Drawing.Point(8, 85);
            this.cboBoxMaterial.Name = "cboBoxMaterial";
            this.cboBoxMaterial.Size = new System.Drawing.Size(250, 21);
            this.cboBoxMaterial.TabIndex = 4;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(264, 85);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 5;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(8, 267);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(282, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(280, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Responsable";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(390, 83);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cIdMaterial
            // 
            this.cIdMaterial.Frozen = true;
            this.cIdMaterial.HeaderText = "MATERIAL";
            this.cIdMaterial.Name = "cIdMaterial";
            this.cIdMaterial.ReadOnly = true;
            this.cIdMaterial.Width = 300;
            // 
            // cIdStock
            // 
            this.cIdStock.Frozen = true;
            this.cIdStock.HeaderText = "STOCK";
            this.cIdStock.Name = "cIdStock";
            this.cIdStock.ReadOnly = true;
            this.cIdStock.Width = 50;
            // 
            // cIdCantidad
            // 
            this.cIdCantidad.Frozen = true;
            this.cIdCantidad.HeaderText = "CANTIDAD";
            this.cIdCantidad.Name = "cIdCantidad";
            this.cIdCantidad.ReadOnly = true;
            this.cIdCantidad.Width = 70;
            // 
            // cIdAcciones
            // 
            this.cIdAcciones.Frozen = true;
            this.cIdAcciones.HeaderText = "Acciones";
            this.cIdAcciones.Name = "cIdAcciones";
            this.cIdAcciones.ReadOnly = true;
            this.cIdAcciones.Width = 110;
            // 
            // FrmNuevoRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 302);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cboBoxMaterial);
            this.Controls.Add(this.txtBoxResponsable);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevoRetiro";
            this.Text = "FrmNuevoRetiro";
            this.Load += new System.EventHandler(this.FrmNuevoRetiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtBoxResponsable;
        private System.Windows.Forms.ComboBox cboBoxMaterial;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn cIdAcciones;
    }
}