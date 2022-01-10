namespace MyExercises
{
    public class HowToReverseString
    {
        public static void Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
}
