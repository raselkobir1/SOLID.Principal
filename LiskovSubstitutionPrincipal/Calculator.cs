namespace LiskovSubstitutionPrincipal
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }
}

/*
 LSP:
    1.Base class instance should be replace with child class instance withoud modifying its behavior. 

    2.The smooth replacement of a parent/superclass class object by a child/sub-class object is known as the 
      Liskov Substitution Principle.
      Ref: https://code-maze.com/liskov-substitution-principle/ 

    3.Or It states that objects of a superclass should be replaceable with objects of a subclass without affecting the 
     correctness of the program.

 */