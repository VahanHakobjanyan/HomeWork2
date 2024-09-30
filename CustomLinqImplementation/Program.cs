using CustomLinqImplementation.Repository;
using System.Collections;

namespace CustomLinqImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRepository testRepository = new MyRepository();
            var people = testRepository.people;
            var cars = testRepository.cars;
            var doubles = testRepository.floats;

            //---All--- 
            //Check if every person is older than 18
            Console.WriteLine("Every person is older than 18 - {0}", people.MyAll(x => x.Age > 18));
            //Check if every car is White
            Console.WriteLine("Every car is White - {0}", cars.MyAll(x => x.Color == "White"));

            //--Any--
            //Check if there is a person who`s id is 31
            Console.WriteLine("There is a person who`s id is 31 - {0}", people.MyAny(x => x.PersonId == 31));
            //Check if there is a car produced after 2019
            Console.WriteLine("There is a car produced after 2019 - {0}", cars.MyAny(x => x.Year > 2020));

            //--Average--
            //Get average of double collection
            Console.WriteLine("Average of double collection - {0}", doubles.MyAverage());

            //Concat
            //Concat two IEnumerables of same type {1, 4, 2} and {76, 43, 22}
            Console.WriteLine("Concat two collections");
            IEnumerable newCollection = new List<int> { 1, 4, 2 }.MyConcat(new List<int> { 76, 43, 22 });
            foreach (var item in newCollection)
                Console.Write("{0} ", item);

            //Contains
            //Check if collection contains specified item 
            Console.WriteLine("\nCollection contains specified item - {0}", doubles.Contains(12));

            //Distinct
            //Return distinct elements from collection
            Console.WriteLine("Get distinct elements from collection");
            var distinct = new List<int> { 1, 1, 2, 2, 5, 6, 6, 7 }.MyDistinct();
            foreach (var item in distinct)
                Console.Write("{0} ", item);

            Console.WriteLine();
            Console.WriteLine(doubles.MyElementAt(0) == 23.678912);
        }
    }
}
