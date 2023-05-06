namespace MovieLibrary.UnitTests
{
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        public void CompareTo_thisMoviePrecedesAnother_returnsNegativeOne()
        {
            Movie thisMovie = new Movie("A");
            Movie anotherMovie = new Movie("B");

            int result = thisMovie.CompareTo(anotherMovie);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CompareTo_thisMovieEqualsAnother_returnsZero()
        {
            Movie thisMovie = new Movie("A");
            Movie anotherMovie = new Movie("A");

            int result = thisMovie.CompareTo(anotherMovie);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareTo_thisMovieFollowsAnother_returnsPositiveOne()
        {
            Movie thisMovie = new Movie("B");
            Movie anotherMovie = new Movie("A");

            int result = thisMovie.CompareTo(anotherMovie);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ToString_genericMovieProperties_returnsStringOfProperties()
        {
            Movie thisMovie = new Movie("ABC", MovieGenre.Comedy, MovieClassification.PG, 90, 5);
            
            string stringOfProperties = thisMovie.ToString();

            string expectedOutput = "Title: ABC Genre: Comedy Classification: PG Duration: 90 Copies: 5";
            Assert.AreEqual(expectedOutput, stringOfProperties);
        }

        [TestMethod]
        public void ToString_titleOnly_returnsStringOfProperties()
        {
            Movie thisMovie = new Movie("ABC");

            string stringOfProperties = thisMovie.ToString();

            string expectedOutput = "Title: ABC Genre: 0 Classification: 0 Duration: 0 Copies: 0";
            Assert.AreEqual(expectedOutput, stringOfProperties);
        }
    }
}