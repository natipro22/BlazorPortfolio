using PortfolioComponents.Models;
using System.Xml.Linq;
using System;

namespace Demo.DataSource;

public class MySkills
{
    public static List<Skill> GetSkills()
    {
        return new List<Skill>
        {
            new Skill
            {
                Name = "Swagger",
                Image = "swagger.png",
                Url = "https://en.wikipedia.org/wiki/Swagger_%28software%29"
            },
            new Skill
            {
                Name = "ASP.NET",
                Image = "aspdotnet.jpg",
                Url = ""
            },
            new Skill
            {
                Name = "Blazor",
                Image = "blazor.png",
                Url = ""
            },
            new Skill
            {
                Name = "C#",
                Image = "csharp.jpg",
                Url = ""
            },
            new Skill
            {
                Name = "LINQ",
                Image = "linq.jpg",
                Url = ""
            },
            new Skill
            {
                Name = "Sql Server",
                Image = "sql-server.png",
                Url = ""
            },
            new Skill
            {
                Name = "Mysql",
                Image = "mysql.png",
                Url = ""
            },
            new Skill
            {
                Name = "Postman",
                Image = "postman.png",
                Url = ""
            },
            new Skill
            {
                Name = "Web API",
                Image = "web-api.png",
                Url = ""
            },
            new Skill
            {
                Name = "Git",
                Image = "git.png",
                Url = ""
            },
            new Skill
            {
                Name = "GitHub",
                Image = "github.png",
                Url = ""
            }

        };

    }
}
