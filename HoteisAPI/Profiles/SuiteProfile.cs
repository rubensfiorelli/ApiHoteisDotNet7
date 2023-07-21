using AutoMapper;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Models;

namespace HoteisAPI.Profiles
{
    public class SuiteProfile : Profile
    {
        public SuiteProfile()
        {
            CreateMap<CreateSuiteDto, Suite>();
            CreateMap<UpdateSuiteDto, Suite>();
            CreateMap<Suite, UpdateSuiteDto>();
            CreateMap<UpdateSuiteDto, Suite>();


        }

    }
}
