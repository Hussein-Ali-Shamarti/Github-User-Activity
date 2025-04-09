GitHub User Activity CLI

A simple command-line application that fetches and displays the recent GitHub activity of any user using the GitHub public API.

What This Tool Does:

This CLI tool allows you to quickly check what a GitHub user has been up to — whether it's pushing commits, opening issues, starring repositories, or more — right from your terminal.

Example output:

Recent GitHub Activity for 'kamranahmedse':

PushEvent in developer-roadmap

IssuesEvent in developer-roadmap

WatchEvent in developer-roadmap

Features:

Fetches recent GitHub activity using GitHub’s public API

Displays actions like pushes, stars, issue activity, and more

Easy to use and lightweight

Written in C# with no external libraries

🛠 Requirements

.NET 7 or later

Internet connection

Installation:

Clone the repo:

git clone https://github.com/Hussein-Ali-Shamarti/github-activity-cli.git

Navigate into the project directory:

cd github-activity-cli

Build the project:

dotnet build

▶️ Usage

Run the following command:

dotnet run -- <github-username>

Example:

dotnet run -- kamranahmedse

This will fetch and print the recent public activity of the specified GitHub user.

How It Works:

Uses HttpClient to make a GET request to:

https://api.github.com/users/<username>/events

Deserializes the JSON response into simple models (GitHubEvent, Repo)

Loops through the activity and prints the event type and repository involved.

📂 File Structure

github-activity-cli/
│
├── Models/
│ ├── GitHubEvent.cs # Model for GitHub events
│ └── Repo.cs # Model for repositories
│
├── Program.cs # Main CLI logic
├── github-activity-cli.csproj
└── README.md # You're reading it :)

Error Handling

If the username is invalid or there's a problem with the API, you'll get a friendly error message like:

Error: Response status code does not indicate success: 404 (Not Found).

Author:

Built by Hussein Ali ShamartiGitHub: @Hussein-Ali-Shamarti
