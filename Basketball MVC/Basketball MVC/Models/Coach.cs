namespace Basketball_MVC.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        //public List<Team> PastTeam;
        public DateTime StartYear { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string FavoriteFood { get; set; }

        //public Coach(string name, Team team, List<Team> pastTeam, DateTime startYear, int wins, int losses, string favoriteFood)
        //{
        //    Name = name;
        //    Team = team;
        //    PastTeam = pastTeam;
        //    StartYear = startYear;
        //    Wins = wins;
        //    Losses = losses;
        //    FavoriteFood = favoriteFood;
        //}
    }
}
