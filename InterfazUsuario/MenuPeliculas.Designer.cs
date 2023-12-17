﻿namespace InterfazUsuario
{
    partial class MenuPeliculas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.LinkLabel();
            this.flpListaPelis = new System.Windows.Forms.FlowLayoutPanel();
            this.LBPersonas = new System.Windows.Forms.ListBox();
            this.btnTodas = new System.Windows.Forms.Button();
            this.btnVistas = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarDirector = new System.Windows.Forms.Button();
            this.btnBuscarActor = new System.Windows.Forms.Button();
            this.flpListaPelis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(825, 18);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(100, 29);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(705, 18);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(103, 29);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administrar";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPerfil.Location = new System.Drawing.Point(19, 17);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(76, 25);
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.TabStop = true;
            this.lblPerfil.Text = "Perfiles";
            this.lblPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPerfil_LinkClicked);
            // 
            // flpListaPelis
            // 
            this.flpListaPelis.AutoScroll = true;
            this.flpListaPelis.Controls.Add(this.LBPersonas);
            this.flpListaPelis.Controls.Add(this.btnBuscarDirector);
            this.flpListaPelis.Controls.Add(this.btnBuscarActor);
            this.flpListaPelis.Location = new System.Drawing.Point(69, 85);
            this.flpListaPelis.Name = "flpListaPelis";
            this.flpListaPelis.Size = new System.Drawing.Size(856, 650);
            this.flpListaPelis.TabIndex = 4;
            // 
            // LBPersonas
            // 
            this.LBPersonas.FormattingEnabled = true;
            this.LBPersonas.ItemHeight = 16;
            this.LBPersonas.Location = new System.Drawing.Point(3, 3);
            this.LBPersonas.Name = "LBPersonas";
            this.LBPersonas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBPersonas.Size = new System.Drawing.Size(423, 100);
            this.LBPersonas.TabIndex = 0;
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(69, 47);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(111, 32);
            this.btnTodas.TabIndex = 5;
            this.btnTodas.Text = "Todas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // btnVistas
            // 
            this.btnVistas.Location = new System.Drawing.Point(186, 47);
            this.btnVistas.Name = "btnVistas";
            this.btnVistas.Size = new System.Drawing.Size(111, 32);
            this.btnVistas.TabIndex = 6;
            this.btnVistas.Text = "Vistas";
            this.btnVistas.UseVisualStyleBackColor = true;
            this.btnVistas.Click += new System.EventHandler(this.btnVistas_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(303, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 32);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarDirector
            // 
            this.btnBuscarDirector.Location = new System.Drawing.Point(432, 3);
            this.btnBuscarDirector.Name = "btnBuscarDirector";
            this.btnBuscarDirector.Size = new System.Drawing.Size(195, 100);
            this.btnBuscarDirector.TabIndex = 3;
            this.btnBuscarDirector.Text = "Buscar por Director";
            this.btnBuscarDirector.UseVisualStyleBackColor = true;
            this.btnBuscarDirector.Click += new System.EventHandler(this.btnBuscarDirector_Click);
            // 
            // btnBuscarActor
            // 
            this.btnBuscarActor.Location = new System.Drawing.Point(633, 3);
            this.btnBuscarActor.Name = "btnBuscarActor";
            this.btnBuscarActor.Size = new System.Drawing.Size(187, 100);
            this.btnBuscarActor.TabIndex = 4;
            this.btnBuscarActor.Text = "Buscar por Actor";
            this.btnBuscarActor.UseVisualStyleBackColor = true;
            this.btnBuscarActor.Click += new System.EventHandler(this.btnBuscarActor_Click);
            // 
            // MenuPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVistas);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.flpListaPelis);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblPerfil);
            this.Name = "MenuPeliculas";
            this.Size = new System.Drawing.Size(1000, 750);
            this.flpListaPelis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.LinkLabel lblPerfil;
        private System.Windows.Forms.FlowLayoutPanel flpListaPelis;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Button btnVistas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox LBPersonas;
        private System.Windows.Forms.Button btnBuscarDirector;
        private System.Windows.Forms.Button btnBuscarActor;
    }
}
