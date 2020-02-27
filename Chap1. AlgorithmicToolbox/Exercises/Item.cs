using System.Collections.Generic;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    
        public class Item
        {
            public int Weight { get; set; }
            public int Value { get; set; }
            public double Cost => (double)Value / Weight;
            public override string ToString()
            {
                return $"C: {Cost} V: {Value} W: {Weight}";
            }
        }
        public class MaxLootComparer : IComparer<Item>
        {
            public int Compare(Item x, Item y)
            {
                return y.Cost.CompareTo(x.Cost);
            }
        }
 
}
