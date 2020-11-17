using System;

namespace _17._studeni
{
    class Episode
    {
        private int numberOfViewers;
        private double maxRating;
        private double ratingSum;


        private Description description;
        public Episode() { }

        public Episode(int numberofViewers, double maxRating, double ratingSum)
        {
            this.numberOfViewers = numberOfViewers;
            this.maxRating = maxRating;
            this.ratingSum = ratingSum;

        }
        public Episode(int numberofViewers, double maxRating, double ratingSum, Description description)
        {
            this.numberOfViewers = numberOfViewers;
            this.maxRating = maxRating;
            this.ratingSum = ratingSum;
            this.description = description;
        }

        Random random = new Random();
        private static double GenerateRandomScore(int min, int max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
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
        public void AddView(double Number)
        {
            if (Number > maxRating)
            {
                maxRating = Number;
                numberOfViewers++;
            }
        }
        public override string ToString()
        {
            return $"{numberOfViewers},{ratingSum},{maxRating},{description.episodeNumber},{description.length},{description.name}";
        }
    }
}
