using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Northwind.API.Models;

namespace Northwind.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IMapper _mapper;

    public CustomersController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet]
    public CustomerResponse Get()
    {
        Customer customer = new Customer()
        {
            FirstName = "Enes",
            LastName = "Uçar",
            Address = "Türkiye",
            City = new City() { Name = "Istanbul" }
        };

        return _mapper.Map<CustomerResponse>(customer);
    }

    [HttpPost]
    public Customer Create(CreateCustomerRequest request)
    {
        Customer customer = _mapper.Map<Customer>(request);
        return customer;
    }
}
