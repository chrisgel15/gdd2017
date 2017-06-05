namespace UberFrba.Listado_Estadistico
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
            this.label1 = new System.Windows.Forms.Label();
            this.aniotxtb = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxTRIMESTRE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.boxOpciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.boxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // aniotxtb
            // 
            this.aniotxtb.Location = new System.Drawing.Point(178, 22);
            this.aniotxtb.Name = "aniotxtb";
            this.aniotxtb.Size = new System.Drawing.Size(100, 26);
            this.aniotxtb.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(410, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Trimestre";
            // 
            // comboBoxTRIMESTRE
            // 
            this.comboBoxTRIMESTRE.FormattingEnabled = true;
            this.comboBoxTRIMESTRE.Location = new System.Drawing.Point(491, 22);
            this.comboBoxTRIMESTRE.Name = "comboBoxTRIMESTRE";
            this.comboBoxTRIMESTRE.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTRIMESTRE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(209, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Qué tipo de listado desea ver?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(267, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Choferes con mayor recaudación";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(321, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Choferes con el viaje más largo realizado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(237, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Clientes con mayor consumo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 104);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(539, 24);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Cliente que utilizo más veces el mismo automóvil en los viajes realizados";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Se mostrará un TOP 5)";
            // 
            // gridResultados
            // 
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Location = new System.Drawing.Point(12, 293);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.RowTemplate.Height = 28;
            this.gridResultados.Size = new System.Drawing.Size(728, 219);
            this.gridResultados.TabIndex = 10;
            // 
            // boxOpciones
            // 
            this.boxOpciones.Controls.Add(this.radioButton1);
            this.boxOpciones.Controls.Add(this.radioButton2);
            this.boxOpciones.Controls.Add(this.radioButton3);
            this.boxOpciones.Controls.Add(this.radioButton4);
            this.boxOpciones.Location = new System.Drawing.Point(101, 144);
            this.boxOpciones.Name = "boxOpciones";
            this.boxOpciones.Size = new System.Drawing.Size(558, 143);
            this.boxOpciones.TabIndex = 11;
            this.boxOpciones.TabStop = false;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 524);
            this.Controls.Add(this.boxOpciones);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTRIMESTRE);
            this.Controls.Add(this.label);
            this.Controls.Add(this.aniotxtb);
            this.Controls.Add(this.label1);
            this.Name = "Opciones";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.boxOpciones.ResumeLayout(false);
            this.boxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aniotxtb;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxTRIMESTRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox boxOpciones;
    }
}