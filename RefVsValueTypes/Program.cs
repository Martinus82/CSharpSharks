using System;

namespace RefVsValueTypes
{
    class Program
    {
        // More info about the structs vs classes here:
        // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct
        // https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-5.0
        static void Main(string[] args)
        {
            PersonClass person1 = new PersonClass("Martin", "Polansky", 38, Gender.Male);
            PersonClass person2 = new PersonClass("Martin", "Polansky", 38, Gender.Male);
            Console.WriteLine($"Is '{nameof(person1)}' equal to '{nameof(person2)}' : {person1.Equals(person2)}");

            // Look into base object class methods (ToString(), GetHashcode(), Equals(), GetType())
            // What do we need to do in order to make those instances queal?
            // What hapens when we pass a type into a methos as a parameter? What? How is it copied?
            // Is reference equality the same thing like instance equality?
            // What is similar to a reference in lower level programming languages like C, C++?
            // What does method GetHashcode() do?
            // What's the difference between object.ReferenceEquals(obj1, obj2) vs object.Equals(obj1, obj2) vs obj.Equals(obj1)
            // Equality oparators ???

            PersonStruct personA = new PersonStruct("Martin", "Polansky", 38, Gender.Male);
            PersonStruct personB = new PersonStruct("Martin", "Polansky", 38, Gender.Male);
            Console.WriteLine($"Is '{nameof(personA)}' equal to '{nameof(personB)}' : {personA.Equals(personB)}");

            // Lets change martinA
            personA.UpdateAge(27);
            Console.WriteLine($"Is '{nameof(personA)}' equal to '{nameof(personB)}' : {personA.Equals(personB)}");

            // common value types (structs): int, uint, double, decimal, bool, byte, DateTime etc... => all primitives!
            // common ref types (every class we write) + string! (even if it behaves as a value type!)
        }
    }
}
