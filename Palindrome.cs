public class Solution {
    public bool IsPalindrome(int x) {
        int original = x;
        int reversed = 0;

        while (x != 0 & x > 0)
        {
            int lastdigit = x % 10;
            reversed = reversed * 10 + lastdigit;
            x = x/10;
        }
        return reversed == original;
    }
}
