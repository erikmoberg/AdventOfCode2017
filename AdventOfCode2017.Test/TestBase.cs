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
            var target = new TTarget();
            return target.Get(input);
        }
    }
}