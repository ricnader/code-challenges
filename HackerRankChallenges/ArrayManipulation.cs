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


    public static long ArrayManipulations(int n, List<List<int>> queries)
    {
        long[] sommands = new long[n];
        int lIdx = 0, rIdx = 0, sommand = 0;
        long topNumber = 0;

        foreach (var query in queries)
        {
            lIdx = query[0];
            rIdx = query[1];
            sommand = query[2];

            for (int i = lIdx; i <= rIdx; i++)
            {
                sommands[i - 1] += sommand;
                topNumber = topNumber < sommands[i - 1] ? sommands[i - 1] : topNumber;
            }
        }
        return topNumber;
    }
}


