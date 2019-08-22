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
    }
}
