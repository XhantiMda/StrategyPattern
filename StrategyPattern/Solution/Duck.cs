using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution
{
    public class Duck
    {
        public Duck(ISwimBehaviour swimBehaviour, IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehavior)
        {
            SwimBehaviour = swimBehaviour;
            QuackBehaviour = quackBehaviour;
            FlyBehaviour = flyBehavior;
        }

        public ISwimBehaviour SwimBehaviour { get; private set; }
        public IQuackBehaviour QuackBehaviour { get; private set; }
        public IFlyBehaviour FlyBehaviour { get; private set; }

    }
}
