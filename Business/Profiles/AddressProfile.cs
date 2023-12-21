﻿using AutoMapper;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, CreateAddressRequest>().ReverseMap();
            CreateMap<Address, UpdateAddressRequest>().ReverseMap();
            CreateMap<Address, DeleteAddressRequest>().ReverseMap();

            CreateMap<Address, CreatedAddressResponse>().ReverseMap();
            CreateMap<Address, UpdatedAddressResponse>().ReverseMap();
            CreateMap<Address, DeletedAddressResponse>().ReverseMap();

            CreateMap<IPaginate<Address>, Paginate<GetListAddressResponse>>().ReverseMap();
            CreateMap<Address, GetListAddressResponse>().ReverseMap();
        }
    }
}
