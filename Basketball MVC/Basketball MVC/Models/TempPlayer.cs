namespace Basketball_MVC.Models
{
    public class TempPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public bool ShootingGuard { get; set; }
        public bool Center { get; set; }
        public bool PointGuard { get; set; }
        public bool PowerForward { get; set; }
        public bool SmallForward { get; set; }
        public double PPG { get; set; }
        public bool IsRetired { get; set; }
    }
}
