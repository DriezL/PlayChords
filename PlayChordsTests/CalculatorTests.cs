using FsCheck;
using FsCheck.NUnit;

namespace PlayChords.Tests
{
    [NUnit.Framework.TestFixture]
    public class CalculatorTests
    {
        [Property]
        public Property TestAdd(int a, int b)
        {
            var calculator = new Calculator();
            return (calculator.Add(a, b) == calculator.Add(b, a))
                .ToProperty();
        }
    }
}