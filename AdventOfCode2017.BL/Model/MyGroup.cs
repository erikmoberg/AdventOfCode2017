using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL.Model
{
    internal class MyGroup
    {
        public MyGroup(MyGroup parent, bool isGarbage)
        {
            this.Children = new List<MyGroup>();
            this.Parent = parent;
            this.IsGarbage = isGarbage;
            if (parent != null)
            {
                this.Parent.Children.Add(this);
            }
        }

        public bool IsGarbage { get; internal set; }
        public List<MyGroup> Children { get; }
        public MyGroup Parent { get; internal set; }
        public int TotalScore
        {
            get
            {
                return this.Score + this.Children.Sum(x => x.TotalScore);
            }
        }

        public int Score
        {
            get
            {
                if (this.IsGarbage)
                {
                    return 0;
                }

                if (this.Parent != null)
                {
                    return this.Parent.Score + 1;
                }

                return 1;
            }
        }

        public int TotalGarbageCount
        {
            get
            {
                return this.GarbageCount + this.Children.Sum(x => x.TotalGarbageCount);
            }
        }

        public int GarbageCount { get; internal set; }
    }
}