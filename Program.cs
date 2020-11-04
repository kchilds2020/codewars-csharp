using System;

namespace CodeWarsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Kevin", "Nikki", "Taylor" };
            string name = Likes.getLikes(arr);
            Console.WriteLine(name);
        }
    }
}
