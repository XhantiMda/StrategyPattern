using System;
using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours.SwimBehaviour
{
    public class SwooshSwimBehavior : ISwimBehaviour
    {
        public string Swim() => "Swoosh!";
    }
}
