using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Xpto.SpecificationPattern.Test
{
    public class SpecificationPatternTest
    {
        private static IEnumerable<TestCaseData> TestCaseData1
        {
            get
            {
                var builder = new MovieBuilder()
                     .WithMpaaRating(MpaaRating.PG13);

                yield return new TestCaseData(builder.Build(), false);

                builder = new MovieBuilder()
                     .WithMpaaRating(MpaaRating.G);

                yield return new TestCaseData(builder.Build(), true);

                builder = new MovieBuilder()
                     .WithMpaaRating(MpaaRating.R);

                yield return new TestCaseData(builder.Build(), false);

            }
        }

        [TestCaseSource(nameof(TestCaseData1))]
        public void When_Mpaa_Rating_Equal_G_Should_Be_Eligible_For_Children(Movie movie, bool assertion)
        {
            Movie.IsEligibleForChildren()
                .IsSatisfiedBy(movie)
                .Should()
                .Be(assertion);
        }
    }
}
