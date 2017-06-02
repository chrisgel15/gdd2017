namespace UberFrba.Abm_Automovil
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
            this.grupoAuto = new System.Windows.Forms.GroupBox();
            this.modifAuto = new System.Windows.Forms.Button();
            this.altaAuto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grupoAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoAuto
            // 
            this.grupoAuto.Controls.Add(this.modifAuto);
            this.grupoAuto.Controls.Add(this.altaAuto);
            this.grupoAuto.Location = new System.Drawing.Point(13, 13);
            this.grupoAuto.Name = "grupoAuto";
            this.grupoAuto.Size = new System.Drawing.Size(149, 114);
            this.grupoAuto.TabIndex = 0;
            this.grupoAuto.TabStop = false;
            this.grupoAuto.Text = "Control de Autos";
            // 
            // modifAuto
            // 
            this.modifAuto.Location = new System.Drawing.Point(7, 60);
            this.modifAuto.Name = "modifAuto";
            this.modifAuto.Size = new System.Drawing.Size(111, 23);
            this.modifAuto.TabIndex = 1;
            this.modifAuto.Text = "Modificar Existente";
            this.modifAuto.UseVisualStyleBackColor = true;
            this.modifAuto.Click += new System.EventHandler(this.modifAuto_Click);
            // 
            // altaAuto
            // 
            this.altaAuto.Location = new System.Drawing.Point(7, 20);
            this.altaAuto.Name = "altaAuto";
            this.altaAuto.Size = new System.Drawing.Size(111, 23);
            this.altaAuto.TabIndex = 0;
            this.altaAuto.Text = "Registro de Autos";
            this.altaAuto.UseVisualStyleBackColor = true;
            this.altaAuto.Click += new System.EventHandler(this.altaAuto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(34, 170);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 219);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grupoAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grupoAuto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoAuto;
        private System.Windows.Forms.Button modifAuto;
        private System.Windows.Forms.Button altaAuto;
        private System.Windows.Forms.Button btnSalir;

    }
}