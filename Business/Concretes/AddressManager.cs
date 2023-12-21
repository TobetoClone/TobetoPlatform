﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        IMapper _mapper;
        AddressBusinessRules _addressBusinessRules;

        public AddressManager(IAddressDal addressDal, IMapper mapper, AddressBusinessRules addressBusinessRules)
        {
            _addressDal = addressDal;
            _mapper = mapper;
            _addressBusinessRules = addressBusinessRules;
        }

        public async Task<CreatedAddressResponse> AddAsync(CreateAddressRequest createAddressRequest)
        {
            Address address = _mapper.Map<Address>(createAddressRequest);
            Address createdAddress = await _addressDal.AddAsync(address);
            CreatedAddressResponse createdAddressResponse = _mapper.Map<CreatedAddressResponse>(createdAddress);
            return createdAddressResponse;
        }

        public async Task<DeletedAddressResponse> DeleteAsync(DeleteAddressRequest deleteAddressRequest)
        {
            await _addressBusinessRules.IsExistsAddress(deleteAddressRequest.Id);
            Address address = _mapper.Map<Address>(deleteAddressRequest);
            Address deletedAddress = await _addressDal.DeleteAsync(address);
            DeletedAddressResponse deletedAddressResponse = _mapper.Map<DeletedAddressResponse>(deletedAddress);
            return deletedAddressResponse;
        }

        public async Task<IPaginate<GetListAddressResponse>> GetListAsync()
        {
            var addresss = await _addressDal.GetListAsync();
            var mappedAddresses = _mapper.Map<Paginate<GetListAddressResponse>>(addresss);
            return mappedAddresses;
        }

        public async Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateAddressRequest)
        {
            await _addressBusinessRules.IsExistsAddress(updateAddressRequest.Id);
            Address address = _mapper.Map<Address>(updateAddressRequest);
            Address updatedAddress = await _addressDal.UpdateAsync(address);
            UpdatedAddressResponse updatedAddressResponse = _mapper.Map<UpdatedAddressResponse>(updatedAddress);
            return updatedAddressResponse;
        }
    }
}
