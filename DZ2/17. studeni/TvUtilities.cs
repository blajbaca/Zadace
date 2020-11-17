using System;


namespace _17._studeni
{
    class TvUtilities
    {

        public static Episode Parse(string episodeInput)
        {
            string[] parsedEpisodes = episodeInput.Split(',');
            int numberOfViewers = int.Parse(parsedEpisodes[0]);
            double ratingSum = double.Parse(parsedEpisodes[1]);
            double maxRating = double.Parse(parsedEpisodes[2]);
            int episodeNumber = int.Parse(parsedEpisodes[3]);
            TimeSpan duration = TimeSpan.Parse(parsedEpisodes[4]);
            string movieName = parsedEpisodes[5];
            Description temp = new Description(episodeNumber, duration, movieName);
            return new Episode(numberOfViewers, ratingSum, maxRating, temp);
        }
        public static void Sort(Episode[] episodes)
        {
            for (int i = 0; i < episodes.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (episodes[j - 1].GetMaxScore() < episodes[j].GetMaxScore())
                    {
                        Episode temp = new Episode();
                        temp = episodes[j - 1];
                        episodes[j - 1] = episodes[j];
                        episodes[j] = temp;
                    }
                }
            }
            
        }


        Random random = new Random();
        private static double GenerateRandomScore(int min, int max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        }
}

