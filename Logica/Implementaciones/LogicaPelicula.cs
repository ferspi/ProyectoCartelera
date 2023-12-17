﻿using Dominio;
using Dominio.Exceptions;
using Logica.Exceptions;
using Logica.Interfaces;
using Repositorio;
using Repositorio.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Implementaciones
{
    public class LogicaPelicula : ILogicaPelicula
    {
        private IPeliculaRepo _repo;
        private IPerfilRepo _repoPerfil;
        private IPersonaRepo _repoPersona;
        private int _criterioElegido;
        public enum Criterios
        {
            OrdenarPorGenero = 0,
            OrdenarPorPatrocinio = 1,
            OrdenarPorPuntaje = 2
        }

        public LogicaPelicula(IPeliculaRepo peliculaRepo, IPerfilRepo perfilRepo, IPersonaRepo repoPersona)
        {
            _repo = peliculaRepo;
            _repoPerfil = perfilRepo;
            CriterioElegido = (int)Criterios.OrdenarPorGenero;
            _repoPersona = repoPersona;
        }
        public void AltaPelicula(Pelicula pelicula, Usuario admin)
        {
            BloquearUsuarioNoAdmin(admin);
            _repo.AgregarPelicula(pelicula);
        }

        public void BajaPelicula(Pelicula pelicula, Usuario admin)
        {
            BloquearUsuarioNoAdmin(admin);
            ChequearNull(pelicula);
            _repo.QuitarPelicula(pelicula);
        }
        private void ChequearNull(Pelicula pelicula)
        {
            if (pelicula == null)
            {
                throw new NullException();
            }
        }

        private void BloquearUsuarioNoAdmin(Usuario admin)
        {
            if (!admin.EsAdministrador)
            {
                throw new UsuarioNoPermitidoException();
            }
        }

        public List<Pelicula> Peliculas()
        {
            return _repo.Peliculas();
        }

        public int CriterioElegido { get => _criterioElegido; set
            {
                ExisteCriterio(value);
                _criterioElegido = value;
            }
        }

        private void ExisteCriterio(int criterio)
        {
            if (!Enum.IsDefined(typeof(Criterios), criterio))
            {
                throw new CriterioInexistenteException();
            }
        }

        public void ElegirCriterioOrden(Usuario admin, int criterio)
        {
            BloquearUsuarioNoAdmin(admin);
            CriterioElegido = criterio;
        }

        private List<Pelicula> OrdenarPorGenero(List<Pelicula> peliculas)
        {
            return peliculas.OrderBy(p => p.GeneroPrincipal.Nombre)
                            .ThenBy(p => p.Nombre)
                            .ThenByDescending(p => p.Identificador).ToList();
        }

        private List<Pelicula> OrdenarPorPatrocinio(List<Pelicula> peliculas)
        {
            return peliculas.OrderByDescending(p => p.EsPatrocinada)
                              .ThenBy(p => p.GeneroPrincipal.Nombre)
                              .ThenBy(p => p.Nombre).ThenByDescending(p => p.Identificador).ToList();
        }

        private List<Pelicula> OrdenarPorPuntaje(Perfil unPerfil, List<Pelicula> peliculas)
        {
            List<Genero> generos = _repoPerfil.GenerosPuntuados(unPerfil).OrderByDescending(g => g.Puntaje)
                                                .Select(g => g.Genero).ToList();

            return peliculas.OrderBy(p => generos.IndexOf(p.GeneroPrincipal))
                            .ThenBy(p => p.Nombre).ThenByDescending(p => p.Identificador).ToList();
        }

        public List<Pelicula> MostrarPeliculas(Perfil unPerfil)
        {
            List<Pelicula> peliculasAMostrar = FiltrarPeliculasSiEsInfantil(unPerfil);

            switch (CriterioElegido)
            {
                case 0:
                    peliculasAMostrar = OrdenarPorGenero(peliculasAMostrar);
                    break;
                case 1:
                    peliculasAMostrar = OrdenarPorPatrocinio(peliculasAMostrar);
                    break;
                case 2:
                    peliculasAMostrar = OrdenarPorPuntaje(unPerfil, peliculasAMostrar);
                    break;
            }
            return peliculasAMostrar;
        }

        public string CriterioSeleccionado()
        {
            return Enum.GetName(typeof(Criterios), _criterioElegido);
        }

        private List<Pelicula> FiltrarPeliculasSiEsInfantil(Perfil unPerfil)
        {
            List<Pelicula> peliculas = Peliculas();

            if (unPerfil.EsInfantil)
            {
                peliculas = Peliculas().Where(x => x.AptaTodoPublico == true).ToList();
            }
            return peliculas;
        }

        public void AgregarGeneroSecundario(Pelicula pelicula, Genero genero)
        {
            _repo.AgregarGeneroSecundario(pelicula, genero);
        }

        public bool EsActor(Pelicula pelicula, Persona persona)
        {
            return _repo.EsActor(pelicula, persona);
        }
        public bool EsDirector(Pelicula pelicula, Persona persona)
        {
            return _repo.EsDirector(pelicula, persona);
        }

        public string Actores(Pelicula pelicula, int cantAMostrar)
        {
            return "Elenco: " + _repo.MostrarActores(pelicula, cantAMostrar);
        }

        public string Directores(Pelicula pelicula, int cantAMostrar)
        {
            return "Dirección: " + _repo.MostrarDirectores(pelicula, cantAMostrar);
        }

        public void AsociarDirector(Persona director, Pelicula pelicula, Usuario admin)
        {
            BloquearUsuarioNoAdmin(admin);
            personaNull(director);
            validarDirectorrepetido(director, pelicula);
            peliculaNull(pelicula);
            ChequearQueExiste(director);
            _repo.AsociarDirector(director, pelicula);
        }

        private void validarDirectorrepetido(Persona director, Pelicula pelicula)
        {
            if (pelicula.Directores.Contains(director))
            {
                throw new DirectorRepetidoException();
            }
        }

        public void DesasociarDirector(Persona director, Pelicula pelicula, Usuario admin)
        {
            BloquearUsuarioNoAdmin(admin);
            peliculaNull(pelicula);
            personaNull(director);
            _repo.DesasociarDirector(director, pelicula);
        }

        public void personaNull(Persona persona)
        {
            if (persona == null)
            {
                throw new PersonaNullException();
            }
        }

        public void peliculaNull(Pelicula pelicula)
        {
            if (pelicula == null)
            {
                throw new PeliculaNullException();
            }
        }

        private void ChequearQueExiste(Persona persona)
        {
            if (!_repoPersona.EstaPersona(persona))
            {
                throw new PersonaInexistenteException();
            }
        }

        public List<Pelicula> BuscarPorActores(List<Persona> actores)
        {
            List<Pelicula> peliculasPorActores = new List<Pelicula>();
            foreach (Persona actor in actores)
            {
                foreach (Pelicula pelicula in _repo.BuscarPorActor(actor))
                {
                    if (!peliculasPorActores.Contains(pelicula))
                    {
                        peliculasPorActores.Add(pelicula);
                    }

                }

            }
            return peliculasPorActores;
        }

        public List<Pelicula> BuscarPorDirectores(List<Persona> directores)
        {
            List < Pelicula > peliculasPorDirectores = new List < Pelicula >();
            foreach (Persona director in directores)
            {
                foreach (Pelicula pelicula in _repo.BuscarPorDirector(director))
                {
                    if(!peliculasPorDirectores.Contains(pelicula))
                    {
                        peliculasPorDirectores.Add(pelicula);
                    }
                    
                }

            }
            return peliculasPorDirectores;
        }

        public List<Papel> DevolverActores(Pelicula pelicula)
        {
            return _repo.Actores(pelicula);
        }

        public List<Persona> DevolverDirectores(Pelicula pelicula)
        {
            return _repo.Directores(pelicula);
        }
    }
}
