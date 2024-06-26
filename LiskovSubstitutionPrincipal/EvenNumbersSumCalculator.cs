﻿using System.Linq;

namespace LiskovSubstitutionPrincipal
{
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate()
        {
            return _numbers.Where(x=> x % 2 == 0).Sum();
        }
    }
}





