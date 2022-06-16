namespace Basketball_MVC.Models
{
    public class Coach
    {
        public string Name;
        public Team Team;
        public List<Team> PastTeam;
        public DateTime StartYear;
        public int Wins;
        public int Losses;
        public string FavoriteFood;

        public Coach(string name, Team team, List<Team> pastTeam, DateTime startYear, int wins, int losses, string favoriteFood)
        {
            Name = name;
            Team = team;
            PastTeam = pastTeam;
            StartYear = startYear;
            Wins = wins;
            Losses = losses;
            FavoriteFood = favoriteFood;
        }
    }
}
