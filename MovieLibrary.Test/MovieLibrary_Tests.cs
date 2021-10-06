using System;
using Xunit;

namespace MovieLibrary.Test
{
    public class MovieLibrary_Tests
    {
        [Fact]
        public void TestIfMoviesExist()
        {
            // ARRANGE
            var movieFile = new MovieFile("movies.csv");

            // ACT
            var movies = movieFile.Movies;

            // ASSERT
            Assert.NotEmpty(movies);
        }

        [Fact]
        public void TestIfMovieEntered()
        {
            // ARRANGE
            var movieFile = new MovieFile("movies.csv");
            
            // ACT
            var result = movieFile.isUniqueTitle("GoldenEye (1995)");

            // ASSERT
            Assert.False(result, "The movie exists in the movies.csv file");
        }
    }
}
