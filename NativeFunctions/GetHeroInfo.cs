using System.ComponentModel;
using System.Globalization;
using Microsoft.SemanticKernel;
using System.Net.Http;
using Newtonsoft.Json.Linq;

public class Info
{
    string apiKey;
    public Info(string superHeroApiKey)
    {
        apiKey = superHeroApiKey;
    }

    [SKFunction, Description("Get the alter ego of a superhero")]
    public string GetAlterEgo(string input)
    {
        // Call the API
        var httpClient = new HttpClient();
        var response = httpClient.GetAsync($"https://superheroapi.com/api/{apiKey}/search/{input}").Result;

        // Get the response
        var responseContent = response.Content.ReadAsStringAsync().Result;

        // Parse the response
        var json = JObject.Parse(responseContent);

        // Get the hero info
        var heroInfo = $"{json["results"][0]["biography"]["full-name"]}";

        // Return the hero info
        return heroInfo;
    }
}
