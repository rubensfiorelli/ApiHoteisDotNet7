using AutoMapper;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Models;

namespace HoteisAPI.Profiles
{
    public class HotelProfile : Profile
    {
        public HotelProfile()
        {

            CreateMap<CreateHotelDto, Hotel>();
            CreateMap<UpdateHotelDto, Hotel>();
            CreateMap<Hotel, UpdateHotelDto>();
            CreateMap<UpdateHotelDto, Hotel>();

        }        


    }
}
