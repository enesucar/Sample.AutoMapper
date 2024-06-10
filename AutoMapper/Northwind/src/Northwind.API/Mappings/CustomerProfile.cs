using AutoMapper;
using Northwind.API.Models;

namespace Northwind.API.Mappings;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CreateCustomerRequest>().ReverseMap();
        CreateMap<Customer, CustomerResponse>()
            .ForMember(dest => dest.FullName, options => options.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ReverseMap();
    }
}
