namespace MovieLibrary.UnitTests
{
    [TestClass]
    public class MovieCollectionTests
    {
        

        [TestMethod]
        public void CreateTestData()
        {
            // All test data mockups - Copy and Paste as needed per test

            // Collection0:
            MovieCollection collection0 = new MovieCollection();

            // Collection1: 
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            MovieCollection collection1 = new MovieCollection();
            collection1.Insert(movie1);

            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);

            // Collection3:
            Movie movie3 = new Movie("Movie Three", MovieGenre.Comedy, MovieClassification.PG, 90, 10);
            Movie movie4 = new Movie("Movie Four", MovieGenre.Comedy, MovieClassification.PG, 90, 25);
            MovieCollection collection3 = new MovieCollection();
            collection3.Insert(movie3);
            collection3.Insert(movie4);

            // CollectionAlphabet:
            //      Root: MovieD
            //      Leaf Nodes: MovieA, MovieC, MovieF
            //      Single Child: MovieE
            //      Two Childs: MovieD, MovieB
            Movie movieA = new Movie("A");
            Movie movieB = new Movie("B");
            Movie movieC = new Movie("C");
            Movie movieD = new Movie("D");
            Movie movieE = new Movie("E");
            Movie movieF = new Movie("F");
            MovieCollection collectionAlphabet = new MovieCollection();
            collectionAlphabet.Insert(movieD);
            collectionAlphabet.Insert(movieB);
            collectionAlphabet.Insert(movieA);
            collectionAlphabet.Insert(movieC);
            collectionAlphabet.Insert(movieE);
            collectionAlphabet.Insert(movieF);
        }


        [TestMethod]
        public void IsEmpty_emptyMovieCollection_returnsTrue()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();

            bool result = collection0.IsEmpty();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmpty_populatedMovieCollection_returnsTrue()
        {
            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);

            bool result = collection2.IsEmpty();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmpty_populatedMovieCollectionWithDvds_returnsFalse()
        {
            // Collection3:
            Movie movie3 = new Movie("Movie Three", MovieGenre.Comedy, MovieClassification.PG, 90, 10);
            Movie movie4 = new Movie("Movie Four", MovieGenre.Comedy, MovieClassification.PG, 90, 25);
            MovieCollection collection3 = new MovieCollection();
            collection3.Insert(movie3);
            collection3.Insert(movie4);

            bool result = collection3.IsEmpty();

            Assert.IsFalse(result);
        }
    }
}