namespace Northwind.API.Models;

public class CreateCustomerRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Address { get; set; }

    public City City { get; set; }

    public CreateCustomerRequest()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Address = string.Empty;
        City = null!;
    }
}
