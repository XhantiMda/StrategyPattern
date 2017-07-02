using System;
using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours
{
    public class WooshFlyBehaviour : IFlyBehaviour
    {
        public string Fly() => "Woosh";
    }
}
