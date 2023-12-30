using PortfolioComponents.Models;

namespace Demo.DataSource;

public class ContactInfo
{
    public static Address GetAddress()
    {
        return new Address
        {
            Email = "pro22nati@gmail.com",
            Phone = "+251905410217"
        };
    }

}
