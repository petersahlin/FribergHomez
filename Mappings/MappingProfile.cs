﻿using AutoMapper;
using FribergHomez.Controllers;
using FribergHomez.Models;

namespace FribergHomez.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //SaleObject
            CreateMap<SaleObject, SalesObjectDto>()
            .ForMember(sODto => sODto.ConstructionYear, opt => opt.MapFrom(s => s.YearOfConstruction))
            .ForMember(sODto => sODto.AnnualOperatingCost, opt => opt.MapFrom(s => s.OperatingCostPerYear))
            .ReverseMap();

            //RealEstateAgent


        }
    }
}