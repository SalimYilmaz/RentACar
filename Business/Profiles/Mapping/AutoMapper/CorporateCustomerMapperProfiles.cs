using AutoMapper;
using Business.Dtos.CorporateCustomer;
using Business.Request.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CorporateCustomerMapperProfiles : Profile
    {
        public CorporateCustomerMapperProfiles()
        {
            CreateMap<AddCorporateCustomerRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, AddCorporateCustomerResponse>();
            CreateMap<UpdateCorporateCustomerRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, UpdateCorporateCustomerResponse>();
            CreateMap<CorporateCustomer, CorporateCustomerListItemDto>();
            CreateMap<IList<CorporateCustomer>, GetCorporateCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<CorporateCustomer, DeleteCorporateCustomerResponse>();
            CreateMap<CorporateCustomer, GetCorporateCustomerByIdResponse>();
        }
    }
}