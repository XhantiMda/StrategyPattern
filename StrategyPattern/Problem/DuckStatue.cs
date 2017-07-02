namespace StrategyPattern.Problem
{
    /// <summary>
    /// This duck cannot fly nor quack
    /// </summary>
    public class DuckStatue : Duck
    {
        protected override string Fly()
        {
            return "I cannot fly";
        }

        protected override string Quack()
        {
            return "I cannot quack";
        }

        protected override string Swim()
        {
            return "I cannot swim";
        }
    }
}
