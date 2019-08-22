using System;
using Xpto.SpecificationPattern.Specifications;

namespace Xpto.SpecificationPattern.Test
{
    public class Movie
    {
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public MpaaRating MpaaRating { get; set; }

        public string Genre { get; set; }

        public double Rating { get; set; }

        public static ExpressionSpecification<Movie> IsEligibleForChildren()
        {
            return new ExpressionSpecification<Movie>(m => m.MpaaRating == MpaaRating.G);
        }
    }

    public enum MpaaRating

    {
        G,
        PG13,
        R
    }
}
