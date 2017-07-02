using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours.QuackBehaviour
{
    public class SkwikSkwikQuackBehviour : IQuackBehaviour
    {
        public string Quack() => "Skwik Skwik";
    }
}
