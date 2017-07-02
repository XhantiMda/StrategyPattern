using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours.SwimBehaviour
{
    public class NoSwimBehaviour : ISwimBehaviour
    {
        public string Swim() => "I cannot swim";
    }
}
