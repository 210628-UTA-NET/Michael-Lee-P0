using System;
//This is a Review Class that Stephen mentioned. 
namespace Models
{
    public class Review
    {
        private int speed;
        public Review(int speed)
        {
            this.speed = speed;    
        }

        public double Rating {get; set;}
        public string Description {get; set;}
    }
}
