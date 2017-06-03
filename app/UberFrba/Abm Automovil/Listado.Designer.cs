namespace UberFrba.Abm_Automovil
{
    partial class Listado
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
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.comboFiltros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Licencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.btnSalir);
            this.groupFiltros.Controls.Add(this.btnClear);
            this.groupFiltros.Controls.Add(this.btnBuscar);
            this.groupFiltros.Controls.Add(this.txtChofer);
            this.groupFiltros.Controls.Add(this.lblChofer);
            this.groupFiltros.Controls.Add(this.txtPatente);
            this.groupFiltros.Controls.Add(this.lblPatente);
            this.groupFiltros.Controls.Add(this.txtModelo);
            this.groupFiltros.Controls.Add(this.lblModelo);
            this.groupFiltros.Controls.Add(this.comboMarca);
            this.groupFiltros.Controls.Add(this.lblMarca);
            this.groupFiltros.Controls.Add(this.comboFiltros);
            this.groupFiltros.Controls.Add(this.label1);
            this.groupFiltros.Location = new System.Drawing.Point(12, 12);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Size = new System.Drawing.Size(581, 170);
            this.groupFiltros.TabIndex = 0;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtros de Búsqueda";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(9, 131);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 59);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(9, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(232, 95);
            this.txtChofer.MaxLength = 20;
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(121, 20);
            this.txtChofer.TabIndex = 9;
            this.txtChofer.Visible = false;
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(182, 98);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(38, 13);
            this.lblChofer.TabIndex = 8;
            this.lblChofer.Text = "Chofer";
            this.lblChofer.Visible = false;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(232, 69);
            this.txtPatente.MaxLength = 20;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(122, 20);
            this.txtPatente.TabIndex = 7;
            this.txtPatente.Visible = false;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(182, 76);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 6;
            this.lblPatente.Text = "Patente";
            this.lblPatente.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(232, 43);
            this.txtModelo.MaxLength = 20;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 5;
            this.txtModelo.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(182, 46);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Visible = false;
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(232, 16);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(121, 21);
            this.comboMarca.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboMarca, "Desplegá el combo y seleccioná la marca");
            this.comboMarca.Visible = false;
            this.comboMarca.SelectionChangeCommitted += new System.EventHandler(this.comboMarca_SelectionChangeCommitted);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(182, 19);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Visible = false;
            // 
            // comboFiltros
            // 
            this.comboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltros.FormattingEnabled = true;
            this.comboFiltros.Location = new System.Drawing.Point(9, 32);
            this.comboFiltros.Name = "comboFiltros";
            this.comboFiltros.Size = new System.Drawing.Size(121, 21);
            this.comboFiltros.TabIndex = 1;
            this.comboFiltros.SelectionChangeCommitted += new System.EventHandler(this.comboFiltros_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros Disponibles";
            // 
            // gridResultados
            // 
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.Modelo,
            this.Licencia,
            this.Patente,
            this.Rodado,
            this.Chofer,
            this.Seleccionar,
            this.Deshabilitar});
            this.gridResultados.Location = new System.Drawing.Point(12, 188);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.Size = new System.Drawing.Size(581, 150);
            this.gridResultados.TabIndex = 1;
            this.gridResultados.Visible = false;
            this.gridResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultados_CellContentClick);
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Marca";
            this.Brand.Name = "Brand";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Licencia
            // 
            this.Licencia.HeaderText = "Licencia";
            this.Licencia.Name = "Licencia";
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            // 
            // Rodado
            // 
            this.Rodado.HeaderText = "Rodado";
            this.Rodado.Name = "Rodado";
            // 
            // Chofer
            // 
            this.Chofer.HeaderText = "Chofer";
            this.Chofer.Name = "Chofer";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            // 
            // Deshabilitar
            // 
            this.Deshabilitar.HeaderText = "";
            this.Deshabilitar.Name = "Deshabilitar";
            this.Deshabilitar.Text = "Deshabilitar";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 480);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.groupFiltros);
            this.Name = "Listado";
            this.Text = "Listado de Selección";
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.ComboBox comboFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chofer;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Deshabilitar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}