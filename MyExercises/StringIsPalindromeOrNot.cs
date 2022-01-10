namespace MyExercises
{
    public class StringIsPalindromeOrNot
    {
        public static void PalindromeOrNot(string myString)
        {
            string reverse = string.Empty;

            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reverse += myString[i];
            }
            if (myString == reverse)
            {
                Console.WriteLine($"{myString} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{myString} is not Palindrome");
            }

        }
    }
}
