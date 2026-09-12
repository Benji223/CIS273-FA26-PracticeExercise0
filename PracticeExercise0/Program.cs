namespace PracticeExercise0;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("    Race Car   "));

        IsNeilNumber(12345678);
    }

    /***
     * Write a method that will take a string and determine if the 
     * string is a palindrome (the same forwards and backward). 
     * Ignore the case and all spaces. 
    */
    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
                while (s[left] == ' ')
            {
                left++;
            }

            while (s[right] == ' ')
            {
                right--;
            }
            
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        } 

        return true;
    }


    /***
     * Write a method that accepts an integer (positive or negative) and 
     * returns the “reversed” number, but retains the sign. 
     * Examples: 
     * ReverseInt(532) => 235; 
     * ReverseInt(-6387) => -7836
     */
    public static int ReverseInt(int i)
    {
        int sign = i < 0 ? -1 : 1;
        int number = Math.Abs(i);
        int reverse = 0;

        while (number > 0)
        {
         int digit = number % 10;
         reverse = reverse * 10 + digit;
         number /= 10;   
        }

        return reverse * sign;

    }


    /***
     * Write a function that will accept a string of alphabetic characters 
     * and determine if all the characters are unique (i.e., no characters 
     * are duplicated). 
     * This comparison should be case INsensitive and ignore spaces.
     */
    public static bool IsUnique(string s)
    { for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsLetter(s[i]))
            {
                continue;
            }
            
            for(int j = i + 1; j < s.Length; j++)
            {
                if (!char.IsLetter(s[j]))
                {
                    continue;
                }

                if (char.ToLower(s[i]) == char.ToLower(s[j]))
                {
                    return false;
                }

            }   
        }

        return true;
    }



    /***
     * A Neil number of m digits is an integer such that the sum of its 
     * digits raised to the mth power is equal to the number itself. For 
     * example, 371 is a Neil number since 3^3 + 7^3 + 1^3 = 371. Write the 
     * following method to test an integer for this property.
     */
    public static bool IsNeilNumber(int i)
    {
        if (i < 0)
        {
            return false;
        }

        int original = i;
        int numberOfDigits = 0;
        int temporary = i;

        if (temporary == 0)
        {
            numberOfDigits = 1;
        }
        else
        {
            while (temporary > 0)
            {
                numberOfDigits++;
                temporary /= 10;
            }
        }

        int sum = 0;
        temporary = i;

        while (temporary > 0)
        {
            int digit = temporary % 10;
            int power = 1;

            for (int count = 0; count < numberOfDigits; count++)
            {
                power *= digit;
            }

            sum += power;
            temporary /= 10;
        }

        return sum == original;
    }


    /***
     * 
     * Write a function that converts phone numbers from this format: 
     * "7three1-6zero8-3one35" 
     * to the standard format:
     * "731-608-3135"
     */
    public static string Convert(string s)
    {
        s = s.Replace("zero", "0");
        s = s.Replace("one", "1");
        s = s.Replace("two", "2");
        s = s.Replace("three", "3");
        s = s.Replace("four", "4");
        s = s.Replace("five", "5");
        s = s.Replace("six", "6");
        s = s.Replace("seven", "7");
        s = s.Replace("eight", "8");
        s = s.Replace("nine", "9");

        return s;
        
    }

}

