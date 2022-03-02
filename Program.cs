using System;

namespace Dotnet_learn
{
    class Program
    {
        static void Main(string[] args)
        {
            storage storage1 = new storage(25,"Black tea");
            string type = storage1._type;
            int weight = storage1._weight;
                Console.WriteLine($"Selected type: {type}, desired amount: {weight} grams.");

        }
    }
}
