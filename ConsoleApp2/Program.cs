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
                                     .Select(j => int.Parse(j))
                                     .ToArray();
                segments[i] = new Segment(segment[0], segment[1]);
            }
            int[] points = CollectingSignatures(segments);
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
            Array.Sort(segments, new SegmentLeftComparer());
            int lowestEndPoint = -1;
            while (index < n)
            {
                startIndex = index;
                var set1 = segments[startIndex];
                var nextIndex = startIndex + 1;
                lowestEndPoint = set1.End;

                while (nextIndex < n)
                {
                    var set2 = segments[nextIndex];
                    if (Intersects(lowestEndPoint, set2.Start))
                    {
                        if (set2.End < lowestEndPoint)
                        {
                            lowestEndPoint = set2.End;
                        }
                        nextIndex += 1;
                    }
                    else
                    {
                        points.Add(lowestEndPoint);

                        break;
                    }
                }
                if (n == nextIndex)
                {
                    points.Add(lowestEndPoint);
                    break;
                }
                index = nextIndex;
            }
            return points.ToArray();
        }

        static bool Intersects(int end, int segmentStart)
        {
            return segmentStart <= end;
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
