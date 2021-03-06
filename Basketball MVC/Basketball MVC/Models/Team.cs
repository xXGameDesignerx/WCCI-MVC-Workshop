namespace Basketball_MVC.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CoachId { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual List<Player> Players { get; set; }
        public string Mascot { get; set; }
        public int PlayerCount 
        { 
            // customizing our 'getter' the . operator
            get 
            { 
                return Players.Count;
            } 
        }

        //public Team(string name, string city, Coach coach, List<Player> players, string mascot)
        //{
        //    Name = name;
        //    City = city;
        //    Coach = coach;
        //    Players = players;
        //    Mascot = mascot;
        //}
    }
}
