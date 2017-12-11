namespace AdventOfCode2017.BL
{
    public interface IResultGenerator<TResult, TInput>
    {
        TResult Get(TInput input);
    }

    public interface IResultGenerator<TResult, TInput, TInput2>
    {
        TResult Get(TInput input, TInput2 input2);
    }
}