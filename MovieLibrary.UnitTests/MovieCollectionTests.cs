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
        public void IsEmpty_populatedMovieCollection_returnsFalse()
        {
            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);

            bool result = collection2.IsEmpty();

            Assert.IsFalse(result);
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

        [TestMethod]
        public void Insert_emptyMovieCollection_returnsTrue()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            bool result = collection0.Insert(movie1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Insert_oneMovieInCollection_returnsTrue()
        {
            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            bool result = collection2.Insert(movie1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Insert_sixMoviesInCollection_returnsTrue()
        {
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
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            bool result = collectionAlphabet.Insert(movie1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Insert_duplicateInCollection_returnsFalse()
        {
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

            bool result = collectionAlphabet.Insert(movieA);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Delete_emptyCollection_returnsFalse()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            bool result = collection0.Delete(movie1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Delete_movieNotPresentInPopulatedCollection_returnsFalse()
        {
            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            bool result = collection2.Delete(movie1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Delete_leafNodeDeletionInPopulatedCollection_returnsTrue()
        {
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

            bool result = collectionAlphabet.Delete(movieA);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete_hasOneChildDeletionInPopulatedCollection_returnsTrue()
        {
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

            bool result = collectionAlphabet.Delete(movieE);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete_hasTwoChildsDeletionInPopulatedCollection_returnsTrue()
        {
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

            bool result = collectionAlphabet.Delete(movieB);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Delete_oneMovieInPopulatedCollection_returnsTrue()
        {
            // Collection1: 
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            MovieCollection collection1 = new MovieCollection();
            collection1.Insert(movie1);

            bool result = collection1.Delete(movie1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Search_emptyMovieCollection_returnsNull()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            IMovie? result = collection0.Search(movie1.Title);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Search_populatedMovieCollectionContainingMovie_returnsNull()
        {
            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);

            IMovie? result = collection2.Search(movie1.Title);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Search_populatedMovieCollectionContainingOneMovie_returnsMovie1()
        {
            // Collection1: 
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            MovieCollection collection1 = new MovieCollection();
            collection1.Insert(movie1);

            IMovie? result = collection1.Search(movie1.Title);

            Assert.AreEqual(result, movie1);
        }

        [TestMethod]
        public void Search_populatedCollection_returnsMovieA()
        {
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

            IMovie? result = collectionAlphabet.Search(movieA.Title);

            Assert.AreEqual(result, movieA);
        }

        [TestMethod]
        public void NoDvds_emptyMovieCollection_returnsZero()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();

            int result = collection0.NoDVDs();

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NoDvds_populatedMovieCollectionNoDvds_returnsZero()
        {
            // Collection2:
            Movie movie2 = new Movie("Movie Two");
            MovieCollection collection2 = new MovieCollection();
            collection2.Insert(movie2);

            int result = collection2.NoDVDs();

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NoDvds_oneMovieWithDvds_returnsFive()
        {
            // Collection1: 
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            MovieCollection collection1 = new MovieCollection();
            collection1.Insert(movie1);

            int result = collection1.NoDVDs();

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void NoDvds_multipleMoviesWithDvds_returnsThirtyFive()
        {
            // Collection3:
            Movie movie3 = new Movie("Movie Three", MovieGenre.Comedy, MovieClassification.PG, 90, 10);
            Movie movie4 = new Movie("Movie Four", MovieGenre.Comedy, MovieClassification.PG, 90, 25);
            MovieCollection collection3 = new MovieCollection();
            collection3.Insert(movie3);
            collection3.Insert(movie4);

            int result = collection3.NoDVDs();

            Assert.AreEqual(result, 35);
        }

        [TestMethod]
        public void ToArray_emptyMovieCollection_returnsEmptyArray()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();

            IMovie[] result = collection0.ToArray();
            IMovie[] expected = new IMovie[0];

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToArray_populatedMovieCollection_returnsSortedArray()
        {
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

            IMovie[] result = collectionAlphabet.ToArray();
            IMovie[] expected = new IMovie[] { movieA, movieB, movieC, movieD, movieE, movieF };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToArray_oneMovieInCollection_returnsArray()
        {
            // Collection1: 
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            MovieCollection collection1 = new MovieCollection();
            collection1.Insert(movie1);

            IMovie[] result = collection1.ToArray();
            IMovie[] expected = new IMovie[] { movie1 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Clear_emptyMovieCollection_resetsMovieCollection()
        {
            // Collection0:
            MovieCollection collection0 = new MovieCollection();

            collection0.Clear();

            int emptyCollection = collection0.Number;

            bool testPasses;
            if (emptyCollection == 0)
            {
                testPasses = true;
            }
            else
            {
                testPasses = false;
            }

            Assert.IsTrue(testPasses);
        }

        [TestMethod]
        public void Clear_populatedMovieCollection_resetsMovieCollection()
        {
            // Collection1: 
            Movie movie1 = new Movie("Movie One", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            MovieCollection collection1 = new MovieCollection();
            collection1.Insert(movie1);

            collection1.Clear();

            IMovie? emptyRoot = collection1.Search(movie1.Title);
            int emptyCollection = collection1.Number;

            bool testPasses;
            if ((emptyRoot == null) && (emptyCollection == 0))
            {
                testPasses = true;
            }
            else
            {
                testPasses = false;
            }

            Assert.IsTrue(testPasses);
        }

        [TestMethod]
        public void Clear_largePopulatedMovieCollection_resetsMovieCollection()
        {
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

            collectionAlphabet.Clear();

            IMovie? emptyRoot = collectionAlphabet.Search(movieD.Title);
            int emptyCollection = collectionAlphabet.Number;

            bool testPasses;
            if ((emptyRoot == null) && (emptyCollection == 0))
            {
                testPasses = true;
            }
            else
            {
                testPasses = false;
            }

            Assert.IsTrue(testPasses);
        }
    }
}