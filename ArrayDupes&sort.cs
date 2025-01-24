
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class removedupe
{
    static void Main()
    {
        int[] RESULT = removeDupes();
        int length = RESULT.Length;
        //joins the array together and seperates with ,
        Console.WriteLine(string.Join(",", RESULT));
    }
    public static int[] removeDupes()
    {
        int[] nums = {19, 24, 19, 23, 45, 64, 24, 66, 302, 23, 24, 51, 135};
        
        //making the array into a hashset which doesn't allow dupes only uniques
        var uniqueNumbers = new HashSet<int>(nums); 
        //making a new array with the size of the hashset
        int[] SortedUniqueNumbers =  new int[uniqueNumbers.Count];
        //copy the hashset into our new array
        uniqueNumbers.CopyTo(SortedUniqueNumbers);
        //sort the array
        Array.Sort(SortedUniqueNumbers);
        
        return SortedUniqueNumbers;
    }
}