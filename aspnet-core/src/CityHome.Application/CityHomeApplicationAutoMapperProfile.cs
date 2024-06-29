using AutoMapper;
using CityHome.Addresses;
using CityHome.PgMembers;
using CityHome.Pgs;

namespace CityHome;

public class CityHomeApplicationAutoMapperProfile : Profile
{
    public CityHomeApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<PgMember, PgMemberDto>();
        CreateMap<CreateUpdatePgMemberDto, PgMember>();

        CreateMap<Pg, PgDto>();
        CreateMap<CreateUpdatePgDto, Pg>();

        CreateMap<Address, AddressDto>();
        CreateMap<CreateUpdateAddressDto, AddressDto>();
       // CreateMap<AddressDto, Address>();


        
        
    }
}
