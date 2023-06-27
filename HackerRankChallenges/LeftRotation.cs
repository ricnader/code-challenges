
#region Problem description
//A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. Given an integer, , rotate the array that many steps left and return the result.

//Function Description

//Complete the rotateLeft function in the editor below.

//rotateLeft has the following parameters:

//int d: the amount to rotate by
//int arr[n]: the array to rotate
//Returns

//int[n]: the rotated array


//sample input 
//5 4
//1 2 3 4 5

//Sample output
//5 1 2 3 4 
#endregion

public static class LeftRotation
{
    public static void Initialize()
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = RotateLeft(d, arr);

    }

    //Solution
    public static List<int> RotateLeft(int d, List<int> arr)
    {
        int delta = d % arr.Count;

        List<int> result = new List<int>();

        for (int i = 0; i < arr.Count; i++)
        {
            int index = i + delta;
            if (index >= arr.Count)
                index -= arr.Count;
            result.Add(arr[index]);
        }

        return result;
    }

}





