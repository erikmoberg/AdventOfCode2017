using System.IO;
using System.Reflection;
using AdventOfCode2017.BL;

namespace AdventOfCode2017.Test
{
    public class TestBase<TTarget, TInput, TResult> : SimpleTestBase 
        where TTarget : IResultGenerator<TResult, TInput>, new()
    {
        protected TResult Get(TInput input)
        {
            var target = this.GetTarget();
            return target.Get(input);
        }

        protected TTarget GetTarget()
        {
            return new TTarget();
        }
    }
}