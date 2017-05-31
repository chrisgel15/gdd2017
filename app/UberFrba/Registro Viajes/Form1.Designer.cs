namespace UberFrba.Registro_Viajes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlChofer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlAuto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlTurno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlCliente = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chofer";
            // 
            // ddlChofer
            // 
            this.ddlChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlChofer.FormattingEnabled = true;
            this.ddlChofer.Location = new System.Drawing.Point(40, 54);
            this.ddlChofer.Name = "ddlChofer";
            this.ddlChofer.Size = new System.Drawing.Size(152, 21);
            this.ddlChofer.TabIndex = 1;
            this.ddlChofer.SelectedIndexChanged += new System.EventHandler(this.ddlChofer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Automovil";
            // 
            // ddlAuto
            // 
            this.ddlAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAuto.FormattingEnabled = true;
            this.ddlAuto.Location = new System.Drawing.Point(40, 110);
            this.ddlAuto.Name = "ddlAuto";
            this.ddlAuto.Size = new System.Drawing.Size(152, 21);
            this.ddlAuto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // ddlTurno
            // 
            this.ddlTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTurno.FormattingEnabled = true;
            this.ddlTurno.Location = new System.Drawing.Point(40, 172);
            this.ddlTurno.Name = "ddlTurno";
            this.ddlTurno.Size = new System.Drawing.Size(152, 21);
            this.ddlTurno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kilometros";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(302, 54);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(120, 20);
            this.txtKilometros.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha y Hora Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "";
            this.dtInicio.Location = new System.Drawing.Point(302, 110);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha y Hora Fin";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(302, 172);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cliente";
            // 
            // ddlCliente
            // 
            this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCliente.FormattingEnabled = true;
            this.ddlCliente.Location = new System.Drawing.Point(40, 227);
            this.ddlCliente.Name = "ddlCliente";
            this.ddlCliente.Size = new System.Drawing.Size(152, 21);
            this.ddlCliente.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 270);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(158, 48);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(265, 347);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "label8";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 418);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ddlCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlChofer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlChofer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtKilometros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}