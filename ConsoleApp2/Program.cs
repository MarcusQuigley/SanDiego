using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var arrayLength = Console.ReadLine();
            //var arrayItems = "3 5 77 3"
            //                       .Split(' ')
            //                       .Select(i => int.Parse(i))
            //                       .ToArray();
 
            

            var n = int.Parse(Console.ReadLine());
            Segment[] segments = new Segment[n];
            for (int i = 0; i < n; i++)
            {
                var segment = Console.ReadLine()
                                     .Split(' ')
                                     .Select(i => int.Parse(i))
                                     .ToArray();
                segments[i] = new Segment(segment[0], segment[1]);
            }
            int[] points = CollectingSignatures(segments);
            Console.WriteLine("----------");
            Console.WriteLine(points.Length);
            foreach (var point in points)
            {
                Console.Write(point + " ");
            }
        }

        static int[] CollectingSignatures(Segment[] segments)
        {
            if (segments == null || segments.Length == 0)
                return new int[] { 0 };
            if (segments.Length == 1)
                return new int[] { segments[0].End };

            int index = 0;
            int startIndex = 0;
            int n = segments.Length;
            List<int> points = new List<int>();
            Array.Sort(segments, new SegmentComparer());

            while (index <= n)
            {
                startIndex = index;
                int startPoint = segments[startIndex].End;
                while (index < n && segments[index].ContainsPoint(startPoint))// segments[index] != segments[startIndex]) //need to see if startIndex segment touchs all new segments
                {
                    index += 1;
                    //need to get the highest value thats touching the segments
                }
                //  if (index > n) throw new Exception();
                if (index <= n)
                {
                    points.Add(startPoint); //need to add this highest value
                                            //      index += 1;
                    if (index == n)
                        break;
                }
            }
            return points.ToArray();
        }

    }
    public class Segment
    {
        public int Start { get; }
        public int End { get; }

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

        public override string ToString()
        {
            return $"S:{Start} E:{End}";
        }
    }

    public class SegmentComparer : IComparer<Segment>
    {
        public int Compare(Segment x, Segment y)
        {
            if (x.Start < y.Start)
                return -1;
            else if (x.Start == y.Start)
                return (x.End <= y.End) ? -1 : 1;
            return 1;
        }
    }
}
