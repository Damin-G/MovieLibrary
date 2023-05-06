namespace MovieLibrary.UnitTests
{
    [TestClass]
    public class MovieCollectionTests
    {
        [TestMethod]
        public void IsEmpty_emptyMovieCollection_returnsTrue()
        {
            MovieCollection collection = new MovieCollection();

            bool result = collection.IsEmpty();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmpty_populatedMovieCollection_returnsFalse()
        {
            MovieCollection collection = new MovieCollection();
            // insert movies into the collection

            bool result = collection.IsEmpty();

            Assert.IsTrue(result);
        }
    }
}