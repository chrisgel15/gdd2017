namespace UberFrba.Rendicion_Viajes
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
            this.label3 = new System.Windows.Forms.Label();
            this.ddlTurno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chofer";
            // 
            // ddlChofer
            // 
            this.ddlChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlChofer.FormattingEnabled = true;
            this.ddlChofer.Location = new System.Drawing.Point(40, 99);
            this.ddlChofer.Name = "ddlChofer";
            this.ddlChofer.Size = new System.Drawing.Size(152, 21);
            this.ddlChofer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // ddlTurno
            // 
            this.ddlTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTurno.FormattingEnabled = true;
            this.ddlTurno.Location = new System.Drawing.Point(40, 158);
            this.ddlTurno.Name = "ddlTurno";
            this.ddlTurno.Size = new System.Drawing.Size(152, 21);
            this.ddlTurno.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha y Hora Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(43, 50);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(211, 206);
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
            this.lblError.Location = new System.Drawing.Point(272, 278);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 181);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlChofer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlChofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}