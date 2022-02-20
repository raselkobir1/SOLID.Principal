using System;
using System.Linq;

namespace LiskovSubstitutionPrincipal
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public virtual int Calculate()
        {
            return _numbers.Sum();
        }
    }
}




















 