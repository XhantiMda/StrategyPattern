namespace StrategyPattern.Problem
{
    /// <summary>
    /// This duck can fly and quack.
    /// </summary>
    public class WildDuck : Duck
    {
        protected override string Fly()
        {
            return "Woosh!";
        }

        protected override string Quack()
        {
            return "Quack Quack";
        }

        protected override string Swim()
        {
            return "Swoosh";
        }
    }
}
