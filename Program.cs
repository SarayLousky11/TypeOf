using System;
using System.Collections.Generic;

class Animal { }
class Dog : Animal { }
class Cat : Animal { }
class Car { }

class Program
{
    static void Main()
    {
        IOfType service = new OfTypeService();

        List<object> mixed = new List<object> { new Dog(), new Cat(), new Car(), "string", 123 };

        // Get only Animals
        var animals = service.GetOfType<Animal>(mixed);
        Console.WriteLine("Animals:");
        foreach (var a in animals)
            Console.WriteLine(a.GetType().Name);

        // Get only strings
        var strings = service.GetOfType<object, string>(mixed);
        Console.WriteLine("Strings:");
        foreach (var s in strings)
            Console.WriteLine(s);

        // OfBase
        List<Dog> dogs = new List<Dog> { new Dog(), new Dog() };
        var baseAnimals = service.OfBase<Animal, Dog>(dogs);
        Console.WriteLine("Base Animals:");
        foreach (var b in baseAnimals)
            Console.WriteLine(b.GetType().Name);
    }
}
