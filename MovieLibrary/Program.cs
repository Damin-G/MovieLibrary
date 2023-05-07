using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;

namespace MovieLibrary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTrials = 100;
            int nMovies = 8000;
            double[] executionTimes = new double[numberOfTrials];
            int titleLength = 5;

            for (int trial = 0; trial < numberOfTrials; trial++)
            {
                MovieCollection collection = new MovieCollection();
                char[] titleChars = new string('A', titleLength).ToCharArray();
                PrintPercentage(trial + 1, numberOfTrials);

                // Use a ConcurrentBag to ensure thread-safety
                ConcurrentBag<Movie> movies = new ConcurrentBag<Movie>();

                // Parallelize the movie creation and insertion
                Parallel.For(1, nMovies + 1, i =>
                {
                    string title = new string(titleChars);

                    Movie movie = new Movie(title, MovieGenre.Drama, MovieClassification.PG, 90, 10);
                    movies.Add(movie);

                    // Increment the last character in the title
                    titleChars[titleLength - 1]++;

                    // Check for character overflow and reset to 'A' if necessary
                    for (int j = titleLength - 1; j >= 0; j--)
                    {
                        if (titleChars[j] > 'Z')
                        {
                            titleChars[j] = 'A';
                            if (j - 1 >= 0)
                            {
                                titleChars[j - 1]++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                });

                // Add movies to the collection
                foreach (var movie in movies)
                {
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

        private static double CalculateAverage(double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum / values.Length;
        }

        public static void PrintPercentage(int progress, int total)
        {
            double percent = (double)progress / total * 100;

            Console.Write($"\rProgress: {percent:0.00}%");

            // If the progress is complete, print a newline
            if (progress == total)
            {
                Console.WriteLine();
            }
        }
    }
}