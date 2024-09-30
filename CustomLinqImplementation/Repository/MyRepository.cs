using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinqImplementation.Repository
{
    internal class MyRepository
    {
        public MyRepository() { }

        public IEnumerable<double> floats = new List<double>
        {
            12.456789, 23.678912, 34.123456, 45.789123, 56.891234,
            67.345678, 78.456789, 89.567891, 90.678912, 12.345678,
            23.456789, 34.567891, 45.678912, 56.789123, 67.891234,
            78.901234, 89.012345, 90.123456, 12.345678, 23.456789,
            34.567891, 45.678912, 56.789123, 67.891234, 78.901234
        };

        public IEnumerable<Person> people = new List<Person>
        {
            new Person(1, "John Doe", 30, "john.doe@gmail.com"),
            new Person(2, "Jane Smith", 25, "jane.smith@yahoo.com"),
            new Person(3, "Michael Johnson", 40, "michael.johnson@hotmail.com"),
            new Person(4, "Emily Davis", 32, "emily.davis@outlook.com"),
            new Person(5, "William Brown", 28, "william.brown@example.com"),
            new Person(6, "Sophia Wilson", 22, "sophia.wilson@gmail.com"),
            new Person(7, "James Miller", 35, "james.miller@company.com"),
            new Person(8, "Olivia Moore", 29, "olivia.moore@example.com"),
            new Person(9, "Alexander Taylor", 43, "alex.taylor@service.com"),
            new Person(10, "Mia Anderson", 27, "mia.anderson@gmail.com"),
            new Person(11, "Daniel Thomas", 45, "daniel.thomas@yahoo.com"),
            new Person(12, "Amelia Jackson", 34, "amelia.jackson@outlook.com"),
            new Person(13, "Ethan White", 38, "ethan.white@example.com"),
            new Person(14, "Isabella Harris", 26, "isabella.harris@gmail.com"),
            new Person(15, "Henry Martin", 41, "henry.martin@service.com"),
            new Person(16, "Ava Thompson", 33, "ava.thompson@hotmail.com"),
            new Person(17, "Mason Garcia", 31, "mason.garcia@company.com"),
            new Person(18, "Charlotte Martinez", 23, "charlotte.martinez@gmail.com"),
            new Person(19, "Lucas Robinson", 36, "lucas.robinson@example.com"),
            new Person(20, "Liam Clark", 24, "liam.clark@yahoo.com"),
            new Person(21, "Evelyn Rodriguez", 44, "evelyn.rodriguez@outlook.com"),
            new Person(22, "Benjamin Lewis", 39, "benjamin.lewis@company.com"),
            new Person(23, "Harper Walker", 30, "harper.walker@gmail.com"),
            new Person(24, "Jack Hall", 42, "jack.hall@hotmail.com"),
            new Person(25, "Ella Young", 28, "ella.young@service.com")
        };

        public IEnumerable<Car> cars = new List<Car>
        {
            new Car(1, "Toyota", "Camry", 2018, "Blue"),
            new Car(2, "Honda", "Civic", 2020, "Red"),
            new Car(3, "Ford", "Mustang", 2019, "Black"),
            new Car(4, "Chevrolet", "Malibu", 2017, "White"),
            new Car(5, "BMW", "X5", 2021, "Silver"),
            new Car(6, "Mercedes", "C-Class", 2018, "Gray"),
            new Car(7, "Tesla", "Model 3", 2021, "Blue"),
            new Car(8, "Audi", "A4", 2020, "Red"),
            new Car(9, "Volkswagen", "Jetta", 2019, "Black"),
            new Car(10, "Hyundai", "Elantra", 2018, "White"),
            new Car(11, "Subaru", "Outback", 2021, "Green"),
            new Car(12, "Nissan", "Altima", 2020, "Gray"),
            new Car(13, "Mazda", "CX-5", 2019, "Silver"),
            new Car(14, "Volvo", "XC90", 2021, "Black"),
            new Car(15, "Kia", "Sorento", 2020, "Blue"),
            new Car(16, "Jaguar", "F-Pace", 2021, "Red"),
            new Car(17, "Lexus", "RX", 2018, "White"),
            new Car(18, "Acura", "MDX", 2020, "Black"),
            new Car(19, "Porsche", "Cayenne", 2021, "Silver"),
            new Car(20, "Jeep", "Wrangler", 2019, "Green"),
            new Car(21, "GMC", "Sierra", 2018, "Gray"),
            new Car(22, "Dodge", "Charger", 2020, "Red"),
            new Car(23, "Land Rover", "Discovery", 2021, "White"),
            new Car(24, "Ferrari", "488", 2021, "Red"),
            new Car(25, "Lamborghini", "Aventador", 2021, "Yellow")
        };
    }
}
