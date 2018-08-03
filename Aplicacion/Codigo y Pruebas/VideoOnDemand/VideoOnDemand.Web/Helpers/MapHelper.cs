﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoOnDemand.Entities;
using VideoOnDemand.Web.Models;

namespace VideoOnDemand.Web.Helpers
{
    public class MapHelper
    {
        internal static IMapper mapper;

        static MapHelper()
        {
            var config = new MapperConfiguration(x => {
                x.CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
                x.CreateMap<Persona, PersonaViewModel>().ReverseMap();
<<<<<<< HEAD
                x.CreateMap<Media, MediaViewModel>().ReverseMap();
                x.CreateMap<Movie, MovieViewModel>().ReverseMap();
=======
                x.CreateMap<Genero, GeneroViewModel>().ReverseMap();
>>>>>>> 10457ebc1fd8989785070a1a0071ad644ac2e8f2

            });
            mapper = config.CreateMapper();
        }

        public static T Map<T>(object source)
        {
            return mapper.Map<T>(source);
        }
    }
}