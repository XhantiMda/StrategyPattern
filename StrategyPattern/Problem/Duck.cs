namespace StrategyPattern.Problem
{
    /// <summary>
    /// This is a base class for all duck types.
    /// </summary>
    public class Duck
    {
        protected virtual string Quack() => "Default quack";
        protected virtual string Fly() => "Default flying";
        protected virtual string Swim() => "Default swimming";
    }
}
