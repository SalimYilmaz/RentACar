using AutoMapper;
using Business.Abstract;
using Business.Dtos.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class IndividualCustomerMapperProfiles : Profile
    {
        public IndividualCustomerMapperProfiles()
        {
            CreateMap<AddIndividualCustomerRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, AddIndividualCustomerResponse>();
            CreateMap<UpdateIndividualCustomerRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, UpdateIndividualCustomerResponse>();
            CreateMap<IndividualCustomer, IndividualCustomerListItemDto>();
            CreateMap<IList<IndividualCustomer>, GetIndividualCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<IndividualCustomer, DeleteIndividualCustomerResponse>();
            CreateMap<IndividualCustomer, GetIndividualCustomerByIdResponse>();
        }
    }
}