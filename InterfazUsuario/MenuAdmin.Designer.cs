﻿namespace InterfazUsuario
{
    partial class MenuAdmin
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
            this.lblPerfil = new System.Windows.Forms.LinkLabel();
            this.btnAltaPeli = new System.Windows.Forms.Button();
            this.btnBajaPeli = new System.Windows.Forms.Button();
            this.btnAltaGenero = new System.Windows.Forms.Button();
            this.btnBajaGenero = new System.Windows.Forms.Button();
            this.btnSorting = new System.Windows.Forms.Button();
            this.flpAdministrador = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAtras = new System.Windows.Forms.LinkLabel();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btn_AsociarPersonas = new System.Windows.Forms.Button();
            this.btnEditarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPerfil.Location = new System.Drawing.Point(34, 10);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(76, 25);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.TabStop = true;
            this.lblPerfil.Text = "Perfiles";
            this.lblPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPerfil_LinkClicked);
            // 
            // btnAltaPeli
            // 
            this.btnAltaPeli.BackColor = System.Drawing.Color.White;
            this.btnAltaPeli.Location = new System.Drawing.Point(39, 40);
            this.btnAltaPeli.Name = "btnAltaPeli";
            this.btnAltaPeli.Size = new System.Drawing.Size(145, 40);
            this.btnAltaPeli.TabIndex = 1;
            this.btnAltaPeli.Text = "Agregar pelicula";
            this.btnAltaPeli.UseVisualStyleBackColor = false;
            this.btnAltaPeli.Click += new System.EventHandler(this.btnAltaPeli_Click);
            // 
            // btnBajaPeli
            // 
            this.btnBajaPeli.Location = new System.Drawing.Point(197, 40);
            this.btnBajaPeli.Name = "btnBajaPeli";
            this.btnBajaPeli.Size = new System.Drawing.Size(140, 40);
            this.btnBajaPeli.TabIndex = 2;
            this.btnBajaPeli.Text = "Quitar pelicula";
            this.btnBajaPeli.UseVisualStyleBackColor = true;
            this.btnBajaPeli.Click += new System.EventHandler(this.btnBajaPeli_Click_1);
            // 
            // btnAltaGenero
            // 
            this.btnAltaGenero.Location = new System.Drawing.Point(547, 40);
            this.btnAltaGenero.Name = "btnAltaGenero";
            this.btnAltaGenero.Size = new System.Drawing.Size(181, 40);
            this.btnAltaGenero.TabIndex = 4;
            this.btnAltaGenero.Text = "Agregar género";
            this.btnAltaGenero.UseVisualStyleBackColor = true;
            this.btnAltaGenero.Click += new System.EventHandler(this.btnAltaGenero_Click);
            // 
            // btnBajaGenero
            // 
            this.btnBajaGenero.Location = new System.Drawing.Point(748, 40);
            this.btnBajaGenero.Name = "btnBajaGenero";
            this.btnBajaGenero.Size = new System.Drawing.Size(167, 40);
            this.btnBajaGenero.TabIndex = 5;
            this.btnBajaGenero.Text = "Quitar género";
            this.btnBajaGenero.UseVisualStyleBackColor = true;
            this.btnBajaGenero.Click += new System.EventHandler(this.btnBajaGenero_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSorting.Location = new System.Drawing.Point(367, 40);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(162, 40);
            this.btnSorting.TabIndex = 3;
            this.btnSorting.Text = "Ordenar peliculas";
            this.btnSorting.UseVisualStyleBackColor = false;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // flpAdministrador
            // 
            this.flpAdministrador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpAdministrador.Location = new System.Drawing.Point(82, 131);
            this.flpAdministrador.Name = "flpAdministrador";
            this.flpAdministrador.Size = new System.Drawing.Size(794, 533);
            this.flpAdministrador.TabIndex = 9;
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAtras.Location = new System.Drawing.Point(902, 10);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(58, 25);
            this.lblAtras.TabIndex = 6;
            this.lblAtras.TabStop = true;
            this.lblAtras.Text = "Atras";
            this.lblAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAtras_LinkClicked);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(179, 86);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(207, 39);
            this.btnAgregarPersona.TabIndex = 10;
            this.btnAgregarPersona.Text = "Agregar Actor/Director";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btn_AsociarPersonas
            // 
            this.btn_AsociarPersonas.Location = new System.Drawing.Point(647, 86);
            this.btn_AsociarPersonas.Name = "btn_AsociarPersonas";
            this.btn_AsociarPersonas.Size = new System.Drawing.Size(180, 39);
            this.btn_AsociarPersonas.TabIndex = 11;
            this.btn_AsociarPersonas.Text = "Asociar/Desasociar";
            this.btn_AsociarPersonas.UseVisualStyleBackColor = true;
            this.btn_AsociarPersonas.Click += new System.EventHandler(this.btn_AsociarPersonas_Click);
            // 
            // btnEditarPersona
            // 
            this.btnEditarPersona.Location = new System.Drawing.Point(414, 86);
            this.btnEditarPersona.Name = "btnEditarPersona";
            this.btnEditarPersona.Size = new System.Drawing.Size(197, 39);
            this.btnEditarPersona.TabIndex = 12;
            this.btnEditarPersona.Text = "Editar Actor/Director";
            this.btnEditarPersona.UseVisualStyleBackColor = true;
            this.btnEditarPersona.Click += new System.EventHandler(this.btnQuitarPersona_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnEditarPersona);
            this.Controls.Add(this.btn_AsociarPersonas);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.flpAdministrador);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.btnBajaGenero);
            this.Controls.Add(this.btnAltaGenero);
            this.Controls.Add(this.btnBajaPeli);
            this.Controls.Add(this.btnAltaPeli);
            this.Controls.Add(this.lblPerfil);
            this.Name = "MenuAdmin";
            this.Size = new System.Drawing.Size(1000, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblPerfil;
        private System.Windows.Forms.Button btnAltaPeli;
        private System.Windows.Forms.Button btnBajaPeli;
        private System.Windows.Forms.Button btnAltaGenero;
        private System.Windows.Forms.Button btnBajaGenero;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.FlowLayoutPanel flpAdministrador;
        private System.Windows.Forms.LinkLabel lblAtras;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btn_AsociarPersonas;
        private System.Windows.Forms.Button btnEditarPersona;
    }
}
