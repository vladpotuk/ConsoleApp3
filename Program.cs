using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 123456;
        int reversedNumber = ReverseNumber(number);
        Console.WriteLine("Результат: " + reversedNumber);
    }
    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        return reversedNumber;
    }
}
