using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class TwoSum
{
    static void Main()
    {
        //Gemmer resultatet vi returnere fra Two_Sum i arrayet "result"
       int[] result = Two_Sum();
        //hvis vores result array er tomt
       if (result.Length == 0)
       {
        Console.WriteLine("No result was found");
       }else
       {
            Console.WriteLine($"[{result[0]}, {result[1]}]");
       }
    }

    public static int[] Two_Sum()
    {
        //Inputtet vi evaluere
        int[] nums = {1,5,9,8,4,3};
        //target vi leder efter
        int target = 10;

        //for loop (går igennem vores nums array)
        for (int i = 0; i<nums.Length; i++)
        {
            //for loop (går også igennem samme array)
            for (int j = 0; j<nums.Length; j++)
            {
                //hvis vors 2 for loops støder på 2 tal der er = target
                if (nums[i] + nums[j] == target)
                {
                    //retuner det i et nyt array ("result")
                    return new int[] {nums[i], nums[j]};
                } 
            }
        }
        //hvis ingen løsning er fundet, retuner et tomt array
        return new int[0];
    }
}