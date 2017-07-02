using StrategyPattern.Solution.Behaviours.FlyBehaviour;
using StrategyPattern.Solution.Behaviours.QuackBehaviour;
using StrategyPattern.Solution.Behaviours.SwimBehaviour;

namespace StrategyPattern.Solution
{
    public class RubberDuck : Duck
    {
        public RubberDuck(FloatSwimBehaviour swimBehaviour,
            SkwikSkwikQuackBehviour quackBehaviour,
            NoFlyBehaviour flyBehavior) 
            : base(swimBehaviour, quackBehaviour, flyBehavior)
        {

        }
    }
}
