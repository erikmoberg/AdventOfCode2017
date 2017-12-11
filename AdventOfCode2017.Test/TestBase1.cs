using AdventOfCode2017.BL;

namespace AdventOfCode2017.Test
{
    public class TestBase<TTarget, TInput, TInput2, TResult> : SimpleTestBase
        where TTarget : IResultGenerator<TResult, TInput, TInput2>, new()
    {
        protected TResult Get(TInput input, TInput2 input2)
        {
            var target = new TTarget();
            return target.Get(input, input2);
        }
    }
}