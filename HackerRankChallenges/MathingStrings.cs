#region Problem Description
/*
* Complete the 'matchingStrings' function below.
*
* The function is expected to return an INTEGER_ARRAY.
* The function accepts following parameters:
*  1. STRING_ARRAY stringList
*  2. STRING_ARRAY queries
*/

//strings brings a list of strings that the method will use to
//search with the strings that come from queries.


//First input must be an int corresponding of how many strings will be in the list.
//The next lines will be the strings.
//Second input must be an int corresponding of how many strings will be in the list of queries
//The next lines will be the strings.
//From HackerRank 
#endregion

public static class MathingStrings
{
    public static void Initialize()
    {
        int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> stringList = new List<string>();

        for (int i = 0; i < stringListCount; i++)
        {
            string stringListItem = Console.ReadLine();
            stringList.Add(stringListItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = MatchingStrings(stringList, queries);
    }

    //Solution
    public static List<int> MatchingStrings(List<string> stringList, List<string> queries)
    {
        List<int> listResult = new List<int>();

        foreach (string item in queries)
            listResult.Add(
                stringList.FindAll(x => x == item).Count);

        return listResult;
    }
}





