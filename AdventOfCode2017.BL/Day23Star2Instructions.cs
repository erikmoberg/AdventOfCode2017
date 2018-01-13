namespace AdventOfCode2017.BL
{
    using System.Linq;

    public class Day23Star2Instructions : IResultGenerator<long, string[]>
    {
        public long Get(string[] input)
        {
            var a = 0L;
            var b = 0L;
            var c = 0L;
            var d = 0L;
            var e = 0L;
            var f = 0L;
            var g = 0L;
            var h = 0L;

            b = 57;
            c = b;
            if (a != 0)
            {
                b *= 100;
                b -= -100000;
                c = b;
                c -= -17000;
            }

            while (true)
            {
                f = 1;
                d = 2;
                do
                {
                    e = 2;
                    do
                    {
                        g = d;
                        g *= e;
                        g -= b;
                        if (g == 0)
                        {
                            f = 0;
                        }

                        e -= -1;
                        g = e;
                        g -= b;
                    } while (g != 0);

                    d -= -1;
                    g = d;
                    g -= b;
                } while (g != 0);

                if (f == 0)
                {
                    h -= -1;
                    g = b;
                }

                g -= c;
                if (g == 0)
                {
                    return h;
                }

                b -= -17;
            }
        }
    }
}