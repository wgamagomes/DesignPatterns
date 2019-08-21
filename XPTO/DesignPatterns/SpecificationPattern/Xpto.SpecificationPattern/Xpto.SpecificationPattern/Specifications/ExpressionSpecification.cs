using System;
using Xpto.SpecificationPattern.Specifications.Operators;

namespace Xpto.SpecificationPattern.Specifications
{
    public class ExpressionSpecification<T> : CompositeSpecification<T>
    {
        private readonly Func<T, bool> _expression;

        public ExpressionSpecification(Func<T, bool> expression)
        {
            _expression = expression ?? throw new ArgumentException();
        }

        public override bool IsSatisfiedBy(T candidate) =>
            _expression(candidate);
    }
}
