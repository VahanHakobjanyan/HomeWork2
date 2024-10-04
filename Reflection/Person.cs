using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    private int _id;
    public byte Age { get; set; }

    public Person() { }
    public Person(string name, string surname, int id, byte age)
    {
        Name = name;
        Surname = surname;
        _id = id;
        Age = age;
    }

    public void PrintPersonInfo()
    {
        Console.WriteLine($"Full Name - {Name} {Surname}, {Age} years old, ID - {GetId()}");
    }

    private int GetId()
    {
        return _id;
    }
}
