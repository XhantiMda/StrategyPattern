using System;
using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours.FlyBehaviour
{
    public class NoFlyBehaviour : IFlyBehaviour
    {
        public string Fly() => "I fly behaviour";
    }
}
