
#region Problem Description
//Starting with a 1-indexed array of zeros and a list of operations, for each operation
//add a value to each the array element between two given indices, inclusive.
//Once all operations have been performed, return the maximum value in the array.


//Example
//5 3
//1 2 100
//2 5 100
//3 4 100

//output
//    200


//Explanation

//After the first update the list is 100 100 0 0 0.
//After the second update list is 100 200 100 100 100.
//After the third update list is 100 200 200 200 100.

//The maximum value is 200. 
#endregion

class ArrayManipulation
{
    public static void Initialize()
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        long result = ArrayManipulations(n, queries);

        Console.WriteLine(result);
    }

    //Solution
    public static long ArrayManipulations(int n, List<List<int>> queries)
    {
        long[] sommands = new long[n + 1];
        int lIdx = 0, rIdx = 0, sommand = 0;

        foreach (var query in queries)
        {
            lIdx = query[0];
            rIdx = query[1];
            sommand = query[2];

            sommands[lIdx - 1] += sommand;
            sommands[rIdx] -= sommand;
        }

        long maxValue = 0, currentNumber = 0;
        for (int i = 0; i < sommands.Length; i++)
        {
            currentNumber += sommands[i];
            maxValue = currentNumber > maxValue ? currentNumber : maxValue;
        }

        return maxValue;
    }

}


