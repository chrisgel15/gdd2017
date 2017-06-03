namespace UberFrba.Abm_Turno
{
    partial class AltaModificacion
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblValorKilometro = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.txtHoraFin = new System.Windows.Forms.NumericUpDown();
            this.txtValorKilometro = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioBase = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorKilometro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(146, 272);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 35;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(147, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 33);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblValorKilometro
            // 
            this.lblValorKilometro.AutoSize = true;
            this.lblValorKilometro.Location = new System.Drawing.Point(43, 90);
            this.lblValorKilometro.Name = "lblValorKilometro";
            this.lblValorKilometro.Size = new System.Drawing.Size(77, 13);
            this.lblValorKilometro.TabIndex = 28;
            this.lblValorKilometro.Text = "Valor Kilometro";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(272, 40);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(47, 13);
            this.lblHoraFin.TabIndex = 26;
            this.lblHoraFin.Text = "Hora Fin";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(272, 90);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioBase.TabIndex = 23;
            this.lblPrecioBase.Text = "Precio Base";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(46, 165);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(43, 40);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.lblHoraInicio.TabIndex = 18;
            this.lblHoraInicio.Text = "Hora Inicio";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(46, 57);
            this.txtHoraInicio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(120, 20);
            this.txtHoraInicio.TabIndex = 36;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(275, 57);
            this.txtHoraFin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(120, 20);
            this.txtHoraFin.TabIndex = 37;
            // 
            // txtValorKilometro
            // 
            this.txtValorKilometro.DecimalPlaces = 2;
            this.txtValorKilometro.Location = new System.Drawing.Point(46, 106);
            this.txtValorKilometro.Name = "txtValorKilometro";
            this.txtValorKilometro.Size = new System.Drawing.Size(120, 20);
            this.txtValorKilometro.TabIndex = 38;
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.DecimalPlaces = 2;
            this.txtPrecioBase.Location = new System.Drawing.Point(275, 106);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(120, 20);
            this.txtPrecioBase.TabIndex = 39;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(275, 165);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 40;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // AltaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 333);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtValorKilometro);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblValorKilometro);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblHoraInicio);
            this.Name = "AltaModificacion";
            this.Text = "AltaModificacion";
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorKilometro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblValorKilometro;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.NumericUpDown txtHoraInicio;
        private System.Windows.Forms.NumericUpDown txtHoraFin;
        private System.Windows.Forms.NumericUpDown txtValorKilometro;
        private System.Windows.Forms.NumericUpDown txtPrecioBase;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkHabilitado;
    }
}