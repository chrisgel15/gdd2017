namespace UberFrba.Abm_ChoferCliente
{
    partial class FormChoferCliente
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtBusquedaApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblMsgChoferCliente = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.txtDniNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(114, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 9;
            // 
            // txtBusquedaApellido
            // 
            this.txtBusquedaApellido.Location = new System.Drawing.Point(117, 57);
            this.txtBusquedaApellido.MaxLength = 20;
            this.txtBusquedaApellido.Name = "txtBusquedaApellido";
            this.txtBusquedaApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaApellido.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(247, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 265);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(22, 27);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblMsgChoferCliente
            // 
            this.lblMsgChoferCliente.AutoSize = true;
            this.lblMsgChoferCliente.Location = new System.Drawing.Point(343, 87);
            this.lblMsgChoferCliente.Name = "lblMsgChoferCliente";
            this.lblMsgChoferCliente.Size = new System.Drawing.Size(35, 13);
            this.lblMsgChoferCliente.TabIndex = 14;
            this.lblMsgChoferCliente.Text = "label1";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(117, 82);
            this.txtBusquedaNombre.MaxLength = 20;
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaNombre.TabIndex = 15;
            // 
            // txtDniNombre
            // 
            this.txtDniNombre.Location = new System.Drawing.Point(117, 108);
            this.txtDniNombre.MaxLength = 20;
            this.txtDniNombre.Name = "txtDniNombre";
            this.txtDniNombre.Size = new System.Drawing.Size(100, 20);
            this.txtDniNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "DNI";
            // 
            // FormChoferCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDniNombre);
            this.Controls.Add(this.txtBusquedaNombre);
            this.Controls.Add(this.lblMsgChoferCliente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusquedaApellido);
            this.Controls.Add(this.lblTipo);
            this.Name = "FormChoferCliente";
            this.Text = "FormChoferCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtBusquedaApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblMsgChoferCliente;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.TextBox txtDniNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}