using System;

namespace Xpto.SpecificationPattern.Test
{
    public class Movie
    {
        public string Name { get; }

        public DateTime ReleaseDate { get; }

        public MpaaRating MpaaRating { get; }

        public string Genre { get; }

        public double Rating { get; }
    }

    public enum MpaaRating

    {
        G,
        PG13,
        R
    }
}
