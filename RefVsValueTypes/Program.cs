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
            ChangePerson(person1, ref person1, person2, ref person2);
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            // Look into base object class methods (ToString(), GetHashcode(), Equals(), GetType()) => These methods are common for all objects because all objects inherits from the base class "object"
            // What do we need to do in order to make those instances equal? => Implement IEquatable<> interface or override Equal() and GetHashcode() methods.
            // What happens when we pass a type into a methods as a parameter? What and how is it copied? => Reference to the object is copied.
            // Is reference equality the same thing like instance equality? => If two references to an object are equal means they points to the same object. But we can have a two different references to the same object.
            // What is similar to a reference in lower level programming languages like C, C++? => Reference in C# is like pointer in C++. It points to the allocated memory... There could be multiple pointers pointing to the same allocated memory space (object (on heap memory))
            // What does method GetHashcode() do? => The method gets the number which defines object equality (usually used in sorting algorithms where we need to compare object)
            // What's the difference between object.ReferenceEquals(obj1, obj2) vs object.Equals(obj1, obj2) vs obj.Equals(obj1) => If references are equal means they "points" to the same objects. Second method evaluates object equality (by calling Equals() method on the object instance), Third the same as second but not static.
            // Equality operators ??? => always static. Allow me to write something like: obj1 == obj1 => returns true if equal, otherwise false.

            //PersonStruct personA = new PersonStruct("Martin", "Polansky", 38, Gender.Male);
            //PersonStruct personB = new PersonStruct("Martin", "Polansky", 38, Gender.Male);
            //Console.WriteLine($"Is '{nameof(personA)}' equal to '{nameof(personB)}' : {personA.Equals(personB)}");

            //// Lets change martinA
            //personA.UpdateAge(27);
            //Console.WriteLine($"Is '{nameof(personA)}' equal to '{nameof(personB)}' : {personA.Equals(personB)}");

            // common value types (structs): int, uint, double, decimal, bool, byte, DateTime etc... => all primitives!
            // common ref types (every class we write) + string! (even if it behaves as a value type!)
        }

        static void ChangePerson(PersonClass person1, ref PersonClass person1Ref, PersonClass person2, ref PersonClass person2Ref)
        {
            Console.WriteLine(ReferenceEquals(person1, person1Ref));
            Console.WriteLine(ReferenceEquals(person2, person2Ref));

            // assign new person the the person1 and observe what happens in the calling method. Does it change?
            //person1 = new PersonClass("hello", "world", 20, Gender.Female);

            // what in this case?
            //person1Ref = new PersonClass("hello", "world", 20, Gender.Female);
        }
    }
}
