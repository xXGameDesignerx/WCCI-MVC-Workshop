namespace Basketball_MVC.Models
{
    public class Position
    {
        public int Id;
        public string Name;
        //public List<Player> Players;

        public Position(string name) // List<Player> players)
        {
            Name = name;
            //Players = players;
        }
        public Position()
        {

        }
    }
}
