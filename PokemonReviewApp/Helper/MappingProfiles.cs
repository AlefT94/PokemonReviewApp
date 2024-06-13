﻿using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<PokemonCreateDTO,Pokemon>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<Country, CountryDTO>();
            CreateMap<CountryCreateDTO, Country>();
            CreateMap<Owner, OwnerDTO>();
            CreateMap<OwnerCreateDTO, Owner>();
            CreateMap<Review, ReviewDTO>();
            CreateMap<ReviewCreateDTO, Review>();
            CreateMap<Reviewer, ReviewerDTO>();
            CreateMap<ReviewerCreateDTO, Reviewer>();
        }
    }
}
