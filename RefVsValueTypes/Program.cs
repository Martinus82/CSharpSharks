using System;

namespace RefVsValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonClass martin1 = new PersonClass("Martin", "Polansky", 38, Gender.Male);
            PersonClass martin2 = new PersonClass("Martin", "Polansky", 38, Gender.Male);
            Console.WriteLine($"Is '{nameof(martin1)}' equal to '{nameof(martin2)}' : {martin1.Equals(martin2)}");

            // What do we need to do in order to make those instances queal?
            // What hapens when we pass a type into a methos as a parameter? What? How is it copied?
            // Is reference equality the same thing like instance equality?
            // What is similar to a reference in lower level programming languages like C, C++?

            PersonStruct martinA = new PersonStruct("Martin", "Polansky", 38, Gender.Male);
            PersonStruct martinB = new PersonStruct("Martin", "Polansky", 38, Gender.Male);
            Console.WriteLine($"Is '{nameof(martinA)}' equal to '{nameof(martinB)}' : {martinA.Equals(martinB)}");

            // Lets change martinA
            martinA.UpdateAge(27);
            Console.WriteLine($"Is '{nameof(martinA)}' equal to '{nameof(martinB)}' : {martinA.Equals(martinB)}");

            // common value types (structs): int, uint, double, decimal, bool, byte, DateTime etc... => all primitives!
            // common ref types (every class we write) + string! (even if it behaves as a value type!)
        }
    }
}
