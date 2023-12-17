﻿using Dominio;
using Dominio.Exceptions;
using Logica.Exceptions;
using Logica.Implementaciones;
using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class AsociarPersona : UserControl
    {
        private MenuAdmin _menuAdmin;
        private Usuario _usuario;
        private ILogicaPelicula _logicaPelicula;
        private ILogicaPersona _logicaPersona;
        private ILogicaPapel _logicaPapel;
        public AsociarPersona(Usuario usuario, ILogicaPelicula ilogicaPelicula, ILogicaPapel logicaPapel, ILogicaPersona logicaPersona, MenuAdmin menuAdmin)
        {
            InitializeComponent();
            _usuario = usuario;
            _logicaPelicula = ilogicaPelicula;
            _logicaPersona = logicaPersona;
            _menuAdmin = menuAdmin;
            _logicaPapel = logicaPapel;
        }

        private void RBDirector_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            txtPapel.Visible = false;
        }

        private void RBActor_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            txtPapel.Visible = true;
        }

        private void ActualizarComboPeliculas()
        {
            CBPeliculas.Text = "";
            CBPeliculas.Items.Clear();
            CBPeliculas.Items.AddRange(_logicaPelicula.Peliculas().ToArray());
        }

        private void ActualizarComboDirectores(Pelicula pelicula)
        {
            CBDirectores.Text = "";
            CBDirectores.Items.Clear();
            CBDirectores.Items.AddRange(_logicaPelicula.DevolverDirectores(pelicula).ToArray());
        }

        private void ActualizarComboPapeles(Pelicula pelicula)
        {
            CBPapeles.Text = "";
            CBPapeles.Items.Clear();
            CBPapeles.Items.AddRange(_logicaPelicula.DevolverActores(pelicula).ToArray());
        }

        private void ActualizarComboPersonas()
        {
            CBPersonas.Text = "";
            CBPersonas.Items.Clear();
            CBPersonas.Items.AddRange(_logicaPersona.Personas().ToArray());
        }

        private void CBPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pelicula pelicula = CBPeliculas.SelectedItem as Pelicula;
            ActualizarComboDirectores(pelicula);
            ActualizarComboPapeles(pelicula);
        }

        private void AsociarPersona_Load(object sender, EventArgs e)
        {
            ActualizarComboPersonas();
            ActualizarComboPeliculas();
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = CBPeliculas.SelectedItem as Pelicula;
            Persona persona = CBPersonas.SelectedItem as Persona;
            try
            {
                if (RBActor.Checked)
                {
                    Papel papel = new Papel()
                    {
                        Nombre = txtPapel.Text,
                        Actor = persona,
                        Pelicula = pelicula
                    };
                    _logicaPapel.AsociarActorPelicula(papel, _usuario);
                    MessageBox.Show($"Se ha asociado el papel de {papel.Nombre} a {persona.Nombre} correctamente");
                    _menuAdmin.CambiarAsociarDesasociar();
                }
                else
                {
                    _logicaPelicula.AsociarDirector(persona, pelicula, _usuario);
                    MessageBox.Show($"Se ha asociado a {persona.Nombre} como nuevo director correctamente");
                    _menuAdmin.CambiarAsociarDesasociar();
                }
            }
            catch (DatoVacioException)
            {
                MessageBox.Show($"El nombre del papel no debe estar vacío");
            }
            catch (NullException)
            {
                MessageBox.Show($"Se debe seleccionar una pelicula y un actor");
            }
            catch (PersonaNullException)
            {
                MessageBox.Show($"Se debe seleccionar una persona");
            }
            catch (PeliculaNullException)
            {
                MessageBox.Show($"Se debe seleccionar una pelicula");
            }
            catch (DirectorRepetidoException)
            {
                MessageBox.Show($"{persona.Nombre} ya dirige la pelicula");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, la acción no se puede realizar");
            }


        }

        private void btnDesasociarDirector_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = CBPeliculas.SelectedItem as Pelicula;
            Persona persona = CBDirectores.SelectedItem as Persona;
            try
            {
                
                _logicaPelicula.DesasociarDirector(persona, pelicula, _usuario);
                MessageBox.Show($"Se ha desasociado a {persona.Nombre} de la pelicula correctamente");
                _menuAdmin.CambiarAsociarDesasociar();
            }
            catch (PeliculaNullException)
            {
                MessageBox.Show($"Debe seleccionar una pelicula");
            }
            catch (PersonaNullException)
            {
                MessageBox.Show($"Debe seleccionar un director");
            }
        }

        private void btnDesasociarPapel_Click(object sender, EventArgs e)
        {
            Papel papel = CBPapeles.SelectedItem as Papel;
            try
            {
                _logicaPapel.DesasociarActorPelicula(papel, _usuario);
                MessageBox.Show($"Se ha desasociado {papel.Nombre} de la pelicula correctamente");
                _menuAdmin.CambiarAsociarDesasociar();
            }
            catch (PapelNullException)
            {
                MessageBox.Show($"Debe seleccionar una papel");
            }

        }
    }
}
