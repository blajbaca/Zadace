using System;
using System.ComponentModel.DataAnnotations;

namespace Class_Library
{
    class Episode
    {
        private int numberOfViewers=0;
        private double maxRating=0;
        private double ratingSum=0;

        public Episode() { }

        public Episode(int numberOfViewers, double maxRating, double ratingSum)
        {
            this.numberOfViewers = numberOfViewers;
            this.maxRating = maxRating;
            this.ratingSum = ratingSum;

        }
        public void AddView(double number)
        {
            if (number > maxRating)
            {
                maxRating = number;
                numberOfViewers += 1;
            }
        }
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * 10;
        }
        public int GetViewerCount()
        {
            return numberOfViewers;
        }
        public double GetAverageScore()
        {
            return ratingSum / numberOfViewers;
        }
        public double GetMaxScore()
        {
            return maxRating;
        }
    }

}

