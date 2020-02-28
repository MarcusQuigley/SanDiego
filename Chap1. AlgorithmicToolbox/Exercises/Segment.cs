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
         
        public override string ToString()
        {
            return $"S:{Start} E:{End}";
        }
    }
  
    public class SegmentLeftComparer : IComparer<Segment>
    {
        public int Compare(Segment x, Segment y)
        {
            return x.Start - y.Start;
        }
    }
}
