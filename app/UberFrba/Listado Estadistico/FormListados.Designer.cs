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
            this.ChofMayorRecaudacionBTT = new System.Windows.Forms.RadioButton();
            this.ChofViajeMasLargoBTT = new System.Windows.Forms.RadioButton();
            this.ClientesMayorConsumoBTT = new System.Windows.Forms.RadioButton();
            this.ClienteMasVecesAutoBTT = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // aniotxtb
            // 
            this.aniotxtb.Location = new System.Drawing.Point(279, 27);
            this.aniotxtb.Name = "aniotxtb";
            this.aniotxtb.Size = new System.Drawing.Size(100, 26);
            this.aniotxtb.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(511, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Trimestre";
            // 
            // comboBoxTRIMESTRE
            // 
            this.comboBoxTRIMESTRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTRIMESTRE.FormattingEnabled = true;
            this.comboBoxTRIMESTRE.Location = new System.Drawing.Point(592, 27);
            this.comboBoxTRIMESTRE.Name = "comboBoxTRIMESTRE";
            this.comboBoxTRIMESTRE.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTRIMESTRE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(289, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Qué tipo de listado desea ver?";
            // 
            // ChofMayorRecaudacionBTT
            // 
            this.ChofMayorRecaudacionBTT.AutoSize = true;
            this.ChofMayorRecaudacionBTT.Location = new System.Drawing.Point(6, 14);
            this.ChofMayorRecaudacionBTT.Name = "ChofMayorRecaudacionBTT";
            this.ChofMayorRecaudacionBTT.Size = new System.Drawing.Size(267, 24);
            this.ChofMayorRecaudacionBTT.TabIndex = 5;
            this.ChofMayorRecaudacionBTT.TabStop = true;
            this.ChofMayorRecaudacionBTT.Text = "Choferes con mayor recaudación";
            this.ChofMayorRecaudacionBTT.UseVisualStyleBackColor = true;
           
            // 
            // ChofViajeMasLargoBTT
            // 
            this.ChofViajeMasLargoBTT.AutoSize = true;
            this.ChofViajeMasLargoBTT.Location = new System.Drawing.Point(6, 44);
            this.ChofViajeMasLargoBTT.Name = "ChofViajeMasLargoBTT";
            this.ChofViajeMasLargoBTT.Size = new System.Drawing.Size(321, 24);
            this.ChofViajeMasLargoBTT.TabIndex = 6;
            this.ChofViajeMasLargoBTT.TabStop = true;
            this.ChofViajeMasLargoBTT.Text = "Choferes con el viaje más largo realizado";
            this.ChofViajeMasLargoBTT.UseVisualStyleBackColor = true;
         
            // 
            // ClientesMayorConsumoBTT
            // 
            this.ClientesMayorConsumoBTT.AutoSize = true;
            this.ClientesMayorConsumoBTT.Location = new System.Drawing.Point(6, 74);
            this.ClientesMayorConsumoBTT.Name = "ClientesMayorConsumoBTT";
            this.ClientesMayorConsumoBTT.Size = new System.Drawing.Size(237, 24);
            this.ClientesMayorConsumoBTT.TabIndex = 7;
            this.ClientesMayorConsumoBTT.TabStop = true;
            this.ClientesMayorConsumoBTT.Text = "Clientes con mayor consumo";
            this.ClientesMayorConsumoBTT.UseVisualStyleBackColor = true;
            
            // ClienteMasVecesAutoBTT
            // 
            this.ClienteMasVecesAutoBTT.AutoSize = true;
            this.ClienteMasVecesAutoBTT.Location = new System.Drawing.Point(6, 104);
            this.ClienteMasVecesAutoBTT.Name = "ClienteMasVecesAutoBTT";
            this.ClienteMasVecesAutoBTT.Size = new System.Drawing.Size(539, 24);
            this.ClienteMasVecesAutoBTT.TabIndex = 8;
            this.ClienteMasVecesAutoBTT.TabStop = true;
            this.ClienteMasVecesAutoBTT.Text = "Cliente que utilizo más veces el mismo automóvil en los viajes realizados";
            this.ClienteMasVecesAutoBTT.UseVisualStyleBackColor = true;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 124);
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
            this.gridResultados.Size = new System.Drawing.Size(932, 219);
            this.gridResultados.TabIndex = 10;
            // 
            // boxOpciones
            // 
            this.boxOpciones.Controls.Add(this.ChofMayorRecaudacionBTT);
            this.boxOpciones.Controls.Add(this.ChofViajeMasLargoBTT);
            this.boxOpciones.Controls.Add(this.ClientesMayorConsumoBTT);
            this.boxOpciones.Controls.Add(this.ClienteMasVecesAutoBTT);
            this.boxOpciones.Location = new System.Drawing.Point(197, 144);
            this.boxOpciones.Name = "boxOpciones";
            this.boxOpciones.Size = new System.Drawing.Size(558, 143);
            this.boxOpciones.TabIndex = 11;
            this.boxOpciones.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 524);
            this.Controls.Add(this.boxOpciones);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTRIMESTRE);
            this.Controls.Add(this.label);
            this.Controls.Add(this.aniotxtb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
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
        private System.Windows.Forms.RadioButton ChofMayorRecaudacionBTT;
        private System.Windows.Forms.RadioButton ChofViajeMasLargoBTT;
        private System.Windows.Forms.RadioButton ClientesMayorConsumoBTT;
        private System.Windows.Forms.RadioButton ClienteMasVecesAutoBTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.GroupBox boxOpciones;
    }
}