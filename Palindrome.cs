class program
{
    static void Main()
    {
        bool ispalindrome = palindrome();
        Console.WriteLine(ispalindrome);
    }

    public static bool palindrome()
    {
        int x = 343; //Integeren vi tester
        int reversed = 0; //Deklarere vores reversed værdi
        int original = x; //Gemmer x's orginale værdi

        while(x != 0) //mens x ikke er 0 
        {
            int lastdigit = x % 10; //bruger modulus til at finde de sidste tal i x
            reversed = reversed * 10 + lastdigit; 
            //adder tallet til reversed og skubber det mod venstre ved at gange med 10
            x = x/10; //fjerner tallet fra x ved at dividere med 10
        }
        return original == reversed; //returnere true eller false efter udsagnet
    }
}