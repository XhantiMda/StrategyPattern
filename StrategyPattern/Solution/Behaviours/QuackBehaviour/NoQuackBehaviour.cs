using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours.QuackBehaviour
{
    public class NoQuackBehaviour : IQuackBehaviour
    {
        public string Quack() => "I cannot quack";
    }
}
