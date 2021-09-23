using System.Reflection;
using System;
using Xunit;
using MovieTest.Test;

namespace MovieTest.Test
{
    public class UnitTest_Movie
    {
        [Fact]
        public void TestIfMovieEntered()
        {
            var movieTest = new MovieTest();
            bool result = movieTest.Equals(true);

            Assert.False(result, "This should be a movie title");
        }
    }
}
