﻿using Dominio;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.EnDataBase
{
    public class PapelDBRepo : IPapelRepo
    {
        public void AgregarPapel(Papel papel)
        {
            using (ThreatLevelMidnightEntertainmentDBContext tlmeContext = new ThreatLevelMidnightEntertainmentDBContext())
            {
                tlmeContext.Peliculas.Attach(papel.Pelicula);
                tlmeContext.Personas.Attach(papel.Actor);

                tlmeContext.Papeles.Add(papel);
                tlmeContext.SaveChanges();
            }
        }

        public void EliminarPapel(Papel papel)
        {
            using (ThreatLevelMidnightEntertainmentDBContext tlmeContext = new ThreatLevelMidnightEntertainmentDBContext())
            {

                Papel papelABorrar = tlmeContext.Papeles.FirstOrDefault(p => p.Nombre == papel.Nombre && p.Actor.Id == papel.Actor.Id
                    && p.Pelicula.Identificador == papel.Pelicula.Identificador);
                tlmeContext.Papeles.Remove(papelABorrar);
                tlmeContext.SaveChanges();
            }
        }

        public bool ExistePapel(Papel papel)
        {
            using (ThreatLevelMidnightEntertainmentDBContext tlmeContext = new ThreatLevelMidnightEntertainmentDBContext())
            {
                tlmeContext.Papeles.Attach(papel);
                return tlmeContext.Papeles.Include(x => x.Actor).Include(p => p.Pelicula).FirstOrDefault(p => p.Nombre == papel.Nombre 
                    && p.Actor.Id == papel.Actor.Id
                    && p.Pelicula.Identificador == papel.Pelicula.Identificador) != null;
            }
        }

        public List<Papel> Papeles()
        {
            using (ThreatLevelMidnightEntertainmentDBContext tlmeContext = new ThreatLevelMidnightEntertainmentDBContext())
            {
                return tlmeContext.Papeles.Include(p => p.Actor).Include(p=>p.Pelicula).ToList();
            }
        }
    }
}
