using StrategyPattern.Solution.Behaviours;
using StrategyPattern.Solution.Behaviours.Contracts;
using StrategyPattern.Solution.Behaviours.QuackBehaviour;
using StrategyPattern.Solution.Behaviours.SwimBehaviour;

namespace StrategyPattern.Solution
{
    public class WildDuck : Duck
    {
        public WildDuck(SwooshSwimBehavior swimBehaviour, 
            QuackQuackQuackBehaviour quackBehaviour, 
            WooshFlyBehaviour flyBehavior) 
            : base(swimBehaviour, quackBehaviour, flyBehavior)
        {
        }
    }
}
