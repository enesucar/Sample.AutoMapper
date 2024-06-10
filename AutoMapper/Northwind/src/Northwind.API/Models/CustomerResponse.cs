namespace Northwind.API.Models;

public class CustomerResponse
{
    public string FullName { get; set; }

    public string Address { get; set; }

    public City City { get; set; }

    public CustomerResponse()
    {
        FullName = string.Empty;
        Address = string.Empty;
        City = null!;
    }
}
