using AutoMapper;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Models;

namespace HoteisAPI.Profiles
{
    public class HospedeProfile : Profile
    {
        public HospedeProfile()
        {
            CreateMap<CreateHospdeDto, Hospede>();
            CreateMap<UpdateHospedeDto, Hospede>();
            CreateMap<Hospede, UpdateHospedeDto>();
            CreateMap<Hospede, ReadHospedeDto>();

        }


    }
}
