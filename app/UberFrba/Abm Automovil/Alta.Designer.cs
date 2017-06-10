namespace UberFrba.Abm_Automovil
{
    partial class Alta
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNomChofer = new System.Windows.Forms.Label();
            this.txtNomChofer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAcepAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApeChofer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApeChofer = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.lblRodado = new System.Windows.Forms.Label();
            this.txtRodado = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(66, 13);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(100, 21);
            this.comboMarca.TabIndex = 1;
            this.toolTip2.SetToolTip(this.comboMarca, "Desplegá el combo y seleccioná la marca");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 46);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(66, 46);
            this.txtModelo.MaxLength = 20;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(13, 80);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 5;
            this.lblPatente.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(66, 80);
            this.txtPatente.MaxLength = 20;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 6;
            this.txtPatente.TextChanged += new System.EventHandler(this.txtPatente_TextChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(13, 122);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 7;
            this.lblTurno.Text = "Turno";
            this.lblTurno.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNomChofer
            // 
            this.lblNomChofer.AutoSize = true;
            this.lblNomChofer.Location = new System.Drawing.Point(11, 30);
            this.lblNomChofer.Name = "lblNomChofer";
            this.lblNomChofer.Size = new System.Drawing.Size(44, 13);
            this.lblNomChofer.TabIndex = 9;
            this.lblNomChofer.Text = "Nombre";
            // 
            // txtNomChofer
            // 
            this.txtNomChofer.Location = new System.Drawing.Point(61, 30);
            this.txtNomChofer.MaxLength = 100;
            this.txtNomChofer.Name = "txtNomChofer";
            this.txtNomChofer.Size = new System.Drawing.Size(100, 20);
            this.txtNomChofer.TabIndex = 10;
            this.txtNomChofer.TextChanged += new System.EventHandler(this.txtChofer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(172, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(172, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(172, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(167, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // btnAcepAlta
            // 
            this.btnAcepAlta.Location = new System.Drawing.Point(66, 304);
            this.btnAcepAlta.Name = "btnAcepAlta";
            this.btnAcepAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAcepAlta.TabIndex = 15;
            this.btnAcepAlta.Text = "Aceptar";
            this.btnAcepAlta.UseVisualStyleBackColor = true;
            this.btnAcepAlta.Click += new System.EventHandler(this.btnAcepAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(204, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtApeChofer
            // 
            this.txtApeChofer.Location = new System.Drawing.Point(61, 64);
            this.txtApeChofer.MaxLength = 100;
            this.txtApeChofer.Name = "txtApeChofer";
            this.txtApeChofer.Size = new System.Drawing.Size(100, 20);
            this.txtApeChofer.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblApeChofer);
            this.groupBox1.Controls.Add(this.txtApeChofer);
            this.groupBox1.Controls.Add(this.lblNomChofer);
            this.groupBox1.Controls.Add(this.txtNomChofer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(66, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chofer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(167, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "*";
            // 
            // lblApeChofer
            // 
            this.lblApeChofer.AutoSize = true;
            this.lblApeChofer.Location = new System.Drawing.Point(11, 67);
            this.lblApeChofer.Name = "lblApeChofer";
            this.lblApeChofer.Size = new System.Drawing.Size(44, 13);
            this.lblApeChofer.TabIndex = 15;
            this.lblApeChofer.Text = "Apellido";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(224, 46);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(47, 13);
            this.lblLicencia.TabIndex = 19;
            this.lblLicencia.Text = "Licencia";
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(277, 43);
            this.txtLicencia.MaxLength = 20;
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtLicencia.TabIndex = 20;
            // 
            // lblRodado
            // 
            this.lblRodado.AutoSize = true;
            this.lblRodado.Location = new System.Drawing.Point(224, 80);
            this.lblRodado.Name = "lblRodado";
            this.lblRodado.Size = new System.Drawing.Size(45, 13);
            this.lblRodado.TabIndex = 21;
            this.lblRodado.Text = "Rodado";
            // 
            // txtRodado
            // 
            this.txtRodado.Location = new System.Drawing.Point(277, 76);
            this.txtRodado.MaxLength = 20;
            this.txtRodado.Name = "txtRodado";
            this.txtRodado.Size = new System.Drawing.Size(100, 20);
            this.txtRodado.TabIndex = 22;
            // 
            // comboTurno
            // 
            this.comboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(66, 119);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(100, 21);
            this.comboTurno.TabIndex = 23;
            this.comboTurno.SelectionChangeCommitted += new System.EventHandler(this.comboTurno_SelectionChangeCommitted);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 388);
            this.Controls.Add(this.comboTurno);
            this.Controls.Add(this.txtRodado);
            this.Controls.Add(this.lblRodado);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.lblLicencia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcepAlta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label1);
            this.Name = "Alta";
            this.Text = "Alta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblNomChofer;
        private System.Windows.Forms.TextBox txtNomChofer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAcepAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtApeChofer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApeChofer;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label lblRodado;
        private System.Windows.Forms.TextBox txtRodado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox comboTurno;
    }
}