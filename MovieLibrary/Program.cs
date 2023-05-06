using System;

namespace MovieLibrary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("A");
            Movie movie2 = new Movie("B");
            Movie movie3 = new Movie("C", MovieGenre.Drama, MovieClassification.PG, 90, 10);
            Movie movie4 = new Movie("D", MovieGenre.Drama, MovieClassification.PG, 90, 10);
            Movie movie5 = new Movie("E", MovieGenre.Drama, MovieClassification.PG, 90, 10);
            Movie movie26 = new Movie("Z", MovieGenre.Drama, MovieClassification.PG, 90, 10);

            MovieCollection collection = new MovieCollection();
            //collection.Insert(movie3);
            //collection.Insert(movie4);
            //collection.Insert(movie5);
            //collection.Insert(movie2);
            //collection.Insert(movie1);

            //Console.WriteLine(collection.Number);
            //Console.WriteLine(collection.Delete(movie3));
            //Console.WriteLine(collection.Number);
            //Console.WriteLine(collection.Search(movie4.Title).Title);
            //int length = collection.ToArray().ToString;
            //Console.WriteLine(collection.ToArray()[0].Title);
            //Console.WriteLine(collection.ToArray()[1].Title);
            //Console.WriteLine(collection.ToArray()[2].Title);
            //Console.WriteLine(collection.ToArray()[3].Title);
            //Console.WriteLine(collection.ToArray()[4].Title);

            // Create case for deletion with double child node
            collection.Insert(movie4);
            collection.Insert(movie2);
            collection.Insert(movie26);
            collection.Insert(movie1);
            collection.Insert(movie3);

            Console.WriteLine(collection.ToArray());

            var array = collection.ToArray();
            foreach (var item in array)
            {
                Console.Write(item.Title.ToString() + ", ");
            }

            Console.WriteLine(collection.Number);
            Console.WriteLine(collection.NoDVDs());
            Console.WriteLine(collection.Delete(movie2));
            Console.WriteLine(collection.Delete(movie2));

            array = collection.ToArray();
            foreach (var item in array)
            {
                Console.Write(item.Title.ToString() + ", ");
            }

            Console.WriteLine(collection.Number);

            Console.WriteLine(collection.NoDVDs());

            Console.WriteLine(collection.Search(movie5.Title) + "lol");

            //collection.Insert(movie1);

            //var array = collection.ToArray();
            //foreach (var item in array)
            //{
            //    Console.Write(item.Title.ToString() + ", ");
            //}

            //collection.Delete(movie1);

            //array = collection.ToArray();
            //foreach (var item in array)
            //{
            //    Console.Write(item.Title.ToString() + ", ");
            //}
        }
    }
}