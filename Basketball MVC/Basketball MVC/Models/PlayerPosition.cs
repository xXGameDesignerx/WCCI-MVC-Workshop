﻿namespace Basketball_MVC.Models
{
    public class PlayerPosition
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
