using System;

namespace CodeWarsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = AlphabetPosition.convertString("The sunset sets at twelve o' clock.");
            Console.WriteLine(numbers);
        }
    }
}
