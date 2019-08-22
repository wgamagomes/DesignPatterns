using System;

namespace Xpto.SpecificationPattern.Test
{
    public class MovieBuilder
    {
        private Movie _movie;

        public MovieBuilder()
        {
            _movie = new Movie();
        }
        public MovieBuilder WithName(string name)
        {
            _movie.Name = name;
            return this;
        }

        public MovieBuilder WithReleaseDate(DateTime releaseDate)
        {
            _movie.ReleaseDate = releaseDate;
            return this;
        }

        public MovieBuilder WithMpaaRating(MpaaRating mpaaRating)
        {
            _movie.MpaaRating = mpaaRating;
            return this;
        }

        public MovieBuilder WithGenre(string genre)
        {
            _movie.Genre = genre;
            return this;
        }

        public MovieBuilder WithRating(double rating)
        {
            _movie.Rating = rating;
            return this;
        }

        public Movie Build()
        {
            return _movie;
        }
    }

}
