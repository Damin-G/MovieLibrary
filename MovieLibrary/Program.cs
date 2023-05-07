using System;
using System.Diagnostics;

namespace MovieLibrary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTrials = 100;
            int nMovies = 100000;
            double[] executionTimes = new double[numberOfTrials];

            for (int trial = 0; trial < numberOfTrials; trial++)
            {
                MovieCollection collection = new MovieCollection();

                int titleLength = 4;
                HashSet<string> usedTitles = new HashSet<string>();
                Random random = new Random();

                for (int i = 1; i <= nMovies; i++)
                {
                    string title;
                    do
                    {
                        title = GenerateRandomTitle(titleLength, random);
                    } while (usedTitles.Contains(title));
                    usedTitles.Add(title);

                    Movie movie = new Movie(title, MovieGenre.Drama, MovieClassification.PG, 90, 10);
                    collection.Insert(movie);
                }

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                collection.NoDVDs();
                stopwatch.Stop();

                TimeSpan elapsedTime = stopwatch.Elapsed;
                executionTimes[trial] = elapsedTime.TotalMilliseconds;
            }

            double averageExecutionTime = CalculateAverage(executionTimes);
            Console.WriteLine($"Average execution time: {averageExecutionTime} ms");
        }

        private static string GenerateRandomTitle(int length, Random random)
        {
            char[] titleChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                char c = (char)random.Next('A', 'Z' + 1);
                if (random.NextDouble() < 0.5)
                {
                    c = char.ToLower(c);
                }
                titleChars[i] = c;
            }
            return new string(titleChars);
        }

        private static double CalculateAverage(double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum / values.Length;
        }
    }
}