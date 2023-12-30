using Demo.Components.Pages;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using PortfolioComponents.Models;
using System.Text.Json;

namespace Demo.DataSource;

public class JsonConverter
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public JsonConverter(IWebHostEnvironment webHostEnvironment)
    {
        this._webHostEnvironment = webHostEnvironment;
    }

    public List<Skill> GetSkills()
    {
        var webRoot = _webHostEnvironment.WebRootPath;
        var jsonFilePath = Path.Combine(webRoot, "Skills.json");
        // Read the entire contents of the file
        string skillsjson = File.ReadAllText(jsonFilePath);

        // Deserialize the JSON array into a list of Skill objects
        return JsonSerializer.Deserialize<List<Skill>>(skillsjson);
    }
}
