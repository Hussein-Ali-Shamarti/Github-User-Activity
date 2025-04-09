namespace TaskTracker.Models
{
    public class GitHubEvent
    {
        public string Type { get; set; }
        public Repo Repo { get; set; }
    }
}
