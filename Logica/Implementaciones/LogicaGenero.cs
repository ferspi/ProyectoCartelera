﻿using Dominio;
using Logica.Interfaces;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Exceptions;
using System.Linq.Expressions;
using Logica.Exceptions;
using Repositorio.Interfaces;

namespace Logica.Implementaciones
{
    public class LogicaGenero : ILogicaGenero
    {
        private IGeneroRepo _repo;
        public LogicaGenero(IGeneroRepo generoRepo)
        {
            _repo = generoRepo;
        }
        
        public void AgregarGenero(Usuario admin, Genero genero)
        {
            BloquearUsuarioNoAdmin(admin);
            EvaluarSiEsDuplicado(genero);
            _repo.AgregarGenero(genero);
        }

        private void BloquearUsuarioNoAdmin(Usuario admin)
        {
            if (!admin.EsAdministrador)
            {
                throw new UsuarioNoPermitidoException();
            }
        }


        private void EvaluarSiEsDuplicado(Genero genero)
        {
            if (_repo.EstaGenero(genero))
            {
                throw new GeneroDuplicadoException();
            }
        }

        public void EliminarGenero(Usuario admin, Genero genero, ILogicaPelicula logicaPelicula)
        {
            ChequearNull(genero);
            BloquearUsuarioNoAdmin(admin);
            EvaluarSiNoExiste(genero);
            BuscarSiTienePeliculasAsociadas(genero, logicaPelicula);
            _repo.EliminarGenero(genero);
        }

        private void ChequearNull(Genero genero)
        {
            if (genero == null)
            {
                throw new NullException();
            }
        }

        private void EvaluarSiNoExiste(Genero genero)
        {
            if (!_repo.EstaGenero(genero))
            {
                throw new GeneroInexistenteException();
            }
        }

        private void BuscarSiTienePeliculasAsociadas(Genero genero, ILogicaPelicula logicaPelicula)
        {
            Pelicula EsGeneroPrincipal = logicaPelicula.Peliculas().FirstOrDefault(p => p.GeneroPrincipal.Equals(genero));
            Pelicula EsGeneroSecundario = logicaPelicula.Peliculas().FirstOrDefault(p => p.GenerosSecundarios.Contains(genero));
            if(EsGeneroPrincipal != null || EsGeneroSecundario != null)
            {
                throw new GeneroConPeliculaAsociadaException();
            }
        }

        public List<Genero> Generos()
        {
            return _repo.Generos();
        }
    }
}
