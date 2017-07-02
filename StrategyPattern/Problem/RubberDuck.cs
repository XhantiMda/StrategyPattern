namespace StrategyPattern.Problem
{
    /// <summary>
    /// This duck cannot fly nor quack.
    /// </summary>
    public class RubberDuck : Duck
    {
        protected override string Fly()
        {
            return "I cannot fly";
        }

        protected override string Quack()
        {
            return "I can only quack when squezed by my owner, Skwik Skwik!";
        }

        protected override string Swim()
        {
            return "Swimming in the bath tub is my specialty";
        }
    }
}
