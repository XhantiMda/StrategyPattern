using System;
using StrategyPattern.Solution.Behaviours.Contracts;

namespace StrategyPattern.Solution.Behaviours.SwimBehaviour
{
    public class FloatSwimBehaviour : ISwimBehaviour
    {
        public string Swim() => "I float on water";
    }
}
