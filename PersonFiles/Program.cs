using System.Text.Json;

namespace PersonFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("John", "Doe", 25));
            people.Add(new Person("Jane", "Doe", 20));

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/people.json";

            string peopleJson = JsonSerializer.Serialize(people);

            File.WriteAllText(filePath, peopleJson);

            /////

            string json = File.ReadAllText(filePath);

            people = JsonSerializer.Deserialize<List<Person>>(json);

            foreach (var p in people)  
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
