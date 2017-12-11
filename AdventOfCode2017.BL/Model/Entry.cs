using System.Linq;

namespace AdventOfCode2017.BL.Model
{
    internal class Entry
    {
        public string Name { get; internal set; }
        public Entry[] Children { get; internal set; }
        public int Weight { get; internal set; }
        public int Sum
        {
            get
            {
                if (this.Children == null)
                {
                    return Weight;
                }

                return this.Weight + this.Children.Sum(x => x.Sum);
            }
        }

        public int Level { get; internal set; }
        public Entry Parent { get; internal set; }

        public override string ToString()
        {
            return $"{this.Name} - Sum: {this.Sum}";
        }
    }
}