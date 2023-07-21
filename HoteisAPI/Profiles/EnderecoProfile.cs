using AutoMapper;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Models;

namespace HoteisAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {

            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<Endereco, UpdateEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();

            
        }


    }
}
