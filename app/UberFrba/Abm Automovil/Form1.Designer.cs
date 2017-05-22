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
            this.altaAuto = new System.Windows.Forms.Button();
            this.modifAuto = new System.Windows.Forms.Button();
            this.bajaAuto = new System.Windows.Forms.Button();
            this.grupoAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoAuto
            // 
            this.grupoAuto.Controls.Add(this.bajaAuto);
            this.grupoAuto.Controls.Add(this.modifAuto);
            this.grupoAuto.Controls.Add(this.altaAuto);
            this.grupoAuto.Location = new System.Drawing.Point(13, 13);
            this.grupoAuto.Name = "grupoAuto";
            this.grupoAuto.Size = new System.Drawing.Size(149, 138);
            this.grupoAuto.TabIndex = 0;
            this.grupoAuto.TabStop = false;
            this.grupoAuto.Text = "Control de Autos";
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
            // modifAuto
            // 
            this.modifAuto.Location = new System.Drawing.Point(7, 60);
            this.modifAuto.Name = "modifAuto";
            this.modifAuto.Size = new System.Drawing.Size(111, 23);
            this.modifAuto.TabIndex = 1;
            this.modifAuto.Text = "Modificar Existente";
            this.modifAuto.UseVisualStyleBackColor = true;
            // 
            // bajaAuto
            // 
            this.bajaAuto.Location = new System.Drawing.Point(7, 100);
            this.bajaAuto.Name = "bajaAuto";
            this.bajaAuto.Size = new System.Drawing.Size(111, 23);
            this.bajaAuto.TabIndex = 2;
            this.bajaAuto.Text = "Dar Baja";
            this.bajaAuto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 177);
            this.Controls.Add(this.grupoAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grupoAuto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoAuto;
        private System.Windows.Forms.Button bajaAuto;
        private System.Windows.Forms.Button modifAuto;
        private System.Windows.Forms.Button altaAuto;

    }
}