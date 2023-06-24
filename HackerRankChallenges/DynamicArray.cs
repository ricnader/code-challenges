  using System.CodeDom.Compiler;
  using System.Collections.Generic;
  using System.Collections;
  using System.ComponentModel;
  using System.Diagnostics.CodeAnalysis;
  using System.Globalization;
  using System.IO;
  using System.Linq;
  using System.Reflection;
  using System.Runtime.Serialization;
  using System.Text.RegularExpressions;
  using System.Text;
  using System;

class Result
{
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
          int[][] arr = new int[n][];
          int lastAnswer = 0;
          int x=0,y=0,type = 0;     

        for(int i = 0; i < queries.Count;i++)
        {
            type = queries[0][0];
            x = queries[0][1];
            y = queries[0][2];

            if(type== 1){

            arr[(x ^ lastAnswer) % n] = new int[1]{y} ;
            
            } else if(type == 2){
            
            }
        }

          return new List<int>();
        }

}

 class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);
    }
}
