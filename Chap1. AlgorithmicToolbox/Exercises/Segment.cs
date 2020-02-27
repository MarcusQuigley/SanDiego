using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    public class Segment
    {
        public int Start { get; }
        public   int End { get; }

        public Segment(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public bool ContainsSegment(Segment segment)
        {
            if (this.Start >= segment.Start && this.End >= segment.End)
                return true;
            return false;
        }

        public bool ContainsPoint(int point)
        {
            return (point - Start) * (End - point) >= 0;
        }
       // public bool ContainsPoint(int point)
       
        public IEnumerable<int> Intersects(Segment segment)
        {
            //var results = Range().Intersect(set1.Range());
            return Intersects(segment.Range());
        }

        public IEnumerable<int> Intersects(IEnumerable<int> set1)
        {
            var results = Range().Intersect(set1);
            return results;
        }

        public IEnumerable<int> Range()
        {
            return Enumerable.Range(Start, End - Start+1);
        }

        public override string ToString()
        {
            return $"S:{Start} E:{End}";
        }
    }

    public class SegmentComparer : IComparer<Segment>
    {
        public int Compare(Segment x,   Segment y)
        {
            if (x.Start < y.Start)
                return -1;
            else if (x.Start == y.Start)
                return (x.End <= y.End) ? -1 : 1;
            return 1;
        }
    }
}
