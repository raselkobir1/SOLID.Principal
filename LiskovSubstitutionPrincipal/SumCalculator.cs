using System.Linq;

namespace LiskovSubstitutionPrincipal
{
    public class SumCalculator : Calculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers) : base(numbers)
        {
            _numbers = numbers;
        }
        public override int Calculate()
        {
            return _numbers.Sum();
        }
    }
}




















 