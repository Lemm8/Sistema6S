using AutoMapper;
using Sistema6S.Core.DTOs;
using Sistema6S.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema6S.Infrastructure.Mappers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            // ENTIDAD ORIGEN -> ENTIDAD DESTINO
            CreateMap<Auditorias6s, Auditorias6sDto>();
            CreateMap<Auditorias6sDto, Auditorias6s>();
        }
    }
}
