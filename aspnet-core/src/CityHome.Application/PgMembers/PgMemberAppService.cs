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


namespace CityHome.PgMembers
{
    public class PgMemberAppService : ApplicationService, IPgMemberAppService
    {

        private readonly IPgMemberRepository _pgMemberRepository;
        private readonly PgMemberManager _pgMemberManager;
        private readonly IMapper _mapper;

        public PgMemberAppService(
            IPgMemberRepository pgMemberRepository,
            PgMemberManager pgMemberManager,
            IMapper mapper)
        {
            _pgMemberRepository = pgMemberRepository;
            _pgMemberManager = pgMemberManager;
            _mapper = mapper;
        }

        public async Task<PgMemberDto> CreateAsync(CreateUpdatePgMemberDto input)
        {
            try
            {
                var pgMember = _mapper.Map<CreateUpdatePgMemberDto, PgMember>(input);
                pgMember.JobLocationId = input.JobLocation.Id;
                pgMember.PermanentAddressId = input.PermanentAddress.Id;
                await _pgMemberRepository.InsertAsync(pgMember);
                return _mapper.Map<PgMember, PgMemberDto>(pgMember);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task DeleteAsync(Guid id)
        {
            return _pgMemberRepository.DeleteAsync(id);
        }

        //public Task<PgMemberDto> GetAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<PagedResultDto<PgMemberDto>> GetListAsync(GetPgMemberListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(PgMember.Name);
            }

            var pgmembers = await _pgMemberRepository.GetListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting,
                input.Filter
            );

            var totalCount = input.Filter == null
                ? await _pgMemberRepository.CountAsync()
                : await _pgMemberRepository.CountAsync(
                    pgmember => pgmember.Name.Contains(input.Filter));

            var pgMemberDtos = _mapper.Map<List<PgMember>, List<PgMemberDto>>(pgmembers);

            return new PagedResultDto<PgMemberDto>(
                totalCount,
                pgMemberDtos
            );
        }

        public async Task<PgMemberDto> UpdateAsync(Guid id, CreateUpdatePgMemberDto input)
        {
            var pgMember = await _pgMemberRepository.GetAsync(id);
            if (pgMember == null)
            {
                throw new EntityNotFoundException(typeof(PgMember), id);
            }
            _mapper.Map(input, pgMember);
            await _pgMemberRepository.UpdateAsync(pgMember);
            return _mapper.Map<PgMember, PgMemberDto>(pgMember);
        }

    }
}
