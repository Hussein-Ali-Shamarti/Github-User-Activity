using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using github_activity_cli.Models;

class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: dotnet run -- <github-username>");
            return;
        }

        string username = args[0];
        string url = $"https://api.github.com/users/{username}/events";

        using HttpClient client = new();
        client.DefaultRequestHeaders.UserAgent.ParseAdd("GitHubActivityCLI");

        try
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var events = JsonSerializer.Deserialize<List<GitHubEvent>>(json, options);

            Console.WriteLine($"\nRecent GitHub Activity for '{username}':\n");

            foreach (var ev in events!)
            {
                Console.WriteLine($"- {ev.Type} in {ev.Repo?.Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
