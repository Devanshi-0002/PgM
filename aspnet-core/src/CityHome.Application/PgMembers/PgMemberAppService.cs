using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Domain.Repositories;
using AutoMapper;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Application.Services;
using CityHome.Addresses;


namespace CityHome.PgMembers
{
    public class PgMemberAppService : CrudAppService<
         PgMember, // The entity type
         PgMemberDto, // DTO for reading data
         Guid, // Primary key type (assuming Guid)
         PagedAndSortedResultRequestDto, // Input DTO for paging and sorting
         CreateUpdatePgMemberDto, // Input DTO for creating/updating PgMember
         CreateUpdatePgMemberDto>, // Output DTO for creating/updating PgMember
         IPgMemberAppService // Service interface
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Address, Guid> _addressRepository; // Repository for Address entity

        public PgMemberAppService(
            IRepository<PgMember, Guid> repository,
            IMapper mapper,
            IRepository<Address, Guid> addressRepository)
            : base(repository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public override async Task<PgMemberDto> CreateAsync(CreateUpdatePgMemberDto input)
        {
            try
            {
                // Map CreateUpdatePgMemberDto to PgMember entity
                var pgMember = _mapper.Map<CreateUpdatePgMemberDto, PgMember>(input);

                // Map JobCollegeAddress and PermanentAddress if provided
                if (input.JobCollegeAddress != null)
                {
                    pgMember.JobCollegeAddress = _mapper.Map<CreateUpdateAddressDto, Address>(input.JobCollegeAddress);
                    await _addressRepository.InsertAsync(pgMember.JobCollegeAddress);
                }

                if (input.PermanentAddress != null)
                {
                    pgMember.PermanentAddress = _mapper.Map<CreateUpdateAddressDto, Address>(input.PermanentAddress);
                    await _addressRepository.InsertAsync(pgMember.PermanentAddress);
                }

                // Add PgMember entity to repository
                await Repository.InsertAsync(pgMember, autoSave: true);

                // Map PgMember entity back to PgMemberDto and return
                var pgMemberDto = _mapper.Map<PgMember, PgMemberDto>(pgMember);
                return pgMemberDto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public override async Task<PgMemberDto> UpdateAsync(Guid id, CreateUpdatePgMemberDto input)
        {
            // Handle update logic here if necessary
            return await base.UpdateAsync(id, input);
        }
    }

}
