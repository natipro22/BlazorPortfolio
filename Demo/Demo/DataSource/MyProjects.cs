using PortfolioComponents.Models;

namespace Demo.DataSource;

public class MyProjects
{
    public static    List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Name = "Civil Registration System",
                Description = "Event Registration and manangement system for oromia civil registration agency.",
                Image = "/ocra.png",
                Url = "https://app.ocra.gov.et/"
            }
        };
    }
}
