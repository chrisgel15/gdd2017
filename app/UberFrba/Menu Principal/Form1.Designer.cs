namespace UberFrba.Menu_Principal
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
            this.btnAbmAuto = new System.Windows.Forms.Button();
            this.btnABMChofer = new System.Windows.Forms.Button();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnAbmRol = new System.Windows.Forms.Button();
            this.btnAbmTurno = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnRegistroViaje = new System.Windows.Forms.Button();
            this.btnRendicion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbmAuto
            // 
            this.btnAbmAuto.Location = new System.Drawing.Point(12, 100);
            this.btnAbmAuto.Name = "btnAbmAuto";
            this.btnAbmAuto.Size = new System.Drawing.Size(140, 46);
            this.btnAbmAuto.TabIndex = 0;
            this.btnAbmAuto.Text = "ABM Automovil";
            this.btnAbmAuto.UseVisualStyleBackColor = true;
            this.btnAbmAuto.Click += new System.EventHandler(this.btnAbmAuto_Click);
            // 
            // btnABMChofer
            // 
            this.btnABMChofer.Location = new System.Drawing.Point(171, 100);
            this.btnABMChofer.Name = "btnABMChofer";
            this.btnABMChofer.Size = new System.Drawing.Size(140, 46);
            this.btnABMChofer.TabIndex = 1;
            this.btnABMChofer.Text = "ABM Chofer";
            this.btnABMChofer.UseVisualStyleBackColor = true;
            this.btnABMChofer.Click += new System.EventHandler(this.btnABMChofer_Click);
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(340, 100);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(140, 46);
            this.btnABMCliente.TabIndex = 2;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // btnAbmRol
            // 
            this.btnAbmRol.Location = new System.Drawing.Point(12, 191);
            this.btnAbmRol.Name = "btnAbmRol";
            this.btnAbmRol.Size = new System.Drawing.Size(140, 46);
            this.btnAbmRol.TabIndex = 3;
            this.btnAbmRol.Text = "ABM Rol";
            this.btnAbmRol.UseVisualStyleBackColor = true;
            this.btnAbmRol.Click += new System.EventHandler(this.btnAbmRol_Click);
            // 
            // btnAbmTurno
            // 
            this.btnAbmTurno.Location = new System.Drawing.Point(171, 191);
            this.btnAbmTurno.Name = "btnAbmTurno";
            this.btnAbmTurno.Size = new System.Drawing.Size(140, 46);
            this.btnAbmTurno.TabIndex = 4;
            this.btnAbmTurno.Text = "ABM Turno";
            this.btnAbmTurno.UseVisualStyleBackColor = true;
            this.btnAbmTurno.Click += new System.EventHandler(this.btnAbmTurno_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(340, 191);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(140, 46);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnRegistroViaje
            // 
            this.btnRegistroViaje.Location = new System.Drawing.Point(12, 276);
            this.btnRegistroViaje.Name = "btnRegistroViaje";
            this.btnRegistroViaje.Size = new System.Drawing.Size(140, 46);
            this.btnRegistroViaje.TabIndex = 6;
            this.btnRegistroViaje.Text = "Registro de Viaje";
            this.btnRegistroViaje.UseVisualStyleBackColor = true;
            this.btnRegistroViaje.Click += new System.EventHandler(this.btnRegistroViaje_Click);
            // 
            // btnRendicion
            // 
            this.btnRendicion.Location = new System.Drawing.Point(171, 276);
            this.btnRendicion.Name = "btnRendicion";
            this.btnRendicion.Size = new System.Drawing.Size(140, 46);
            this.btnRendicion.TabIndex = 7;
            this.btnRendicion.Text = "Rendicion";
            this.btnRendicion.UseVisualStyleBackColor = true;
            this.btnRendicion.Click += new System.EventHandler(this.btnRendicion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(340, 276);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(140, 46);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(171, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 46);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(28, 52);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Rol:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(104, 22);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(80, 13);
            this.lblNombreUsuario.TabIndex = 12;
            this.lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Location = new System.Drawing.Point(107, 51);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblRolUsuario.TabIndex = 13;
            this.lblRolUsuario.Text = "RolUsuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 443);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnRendicion);
            this.Controls.Add(this.btnRegistroViaje);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnAbmTurno);
            this.Controls.Add(this.btnAbmRol);
            this.Controls.Add(this.btnABMCliente);
            this.Controls.Add(this.btnABMChofer);
            this.Controls.Add(this.btnAbmAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbmAuto;
        private System.Windows.Forms.Button btnABMChofer;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnAbmRol;
        private System.Windows.Forms.Button btnAbmTurno;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnRegistroViaje;
        private System.Windows.Forms.Button btnRendicion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRolUsuario;

    }
}