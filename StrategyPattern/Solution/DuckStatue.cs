using StrategyPattern.Solution.Behaviours.FlyBehaviour;
using StrategyPattern.Solution.Behaviours.QuackBehaviour;
using StrategyPattern.Solution.Behaviours.SwimBehaviour;

namespace StrategyPattern.Solution
{
    public class DuckStatue : Duck
    {
        public DuckStatue(NoSwimBehaviour swimBehaviour,
            NoQuackBehaviour quackBehaviour,
            NoFlyBehaviour flyBehavior) 
            : base(swimBehaviour, quackBehaviour, flyBehavior)
        {

        }
    }
}
