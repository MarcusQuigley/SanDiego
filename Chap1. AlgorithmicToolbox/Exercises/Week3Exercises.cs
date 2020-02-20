using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
   public class Week3Exercises
    {

        public int GetChange(int weight)
        {
           // Array.Sort(items,new MimimumComparer());
            int[] items = new int[] { 10, 5, 1};
          //  int count = items.Length;
            // int[] answers = new int[count] { };
            List<int> answers = new List<int>();
            //int v = 0;
            int item = 0;
            while(weight>0)
            //for(int i=0;i< count; i++)
            {
                //if (weight == 0)
                //{
                //    return v;
                //}

                //select item with less than weight miniumm weight
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[j] < weight)
                    {
                        item = items[j];
                        break;
                    }
                }
               // v += item;
                answers.Add(item);
                weight -= item;
             }
             
            return answers.Count;// v;
        }
    }
    public class MimimumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            return y;
        }
    }
}
