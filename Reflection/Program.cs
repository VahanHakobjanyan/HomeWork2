using System.Dynamic;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type classType = typeof(Person);

            PropertyInfo[] properties = classType.GetProperties();
            FieldInfo[] fileds = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            MethodInfo[] methods = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            var instanceOfClass = Activator.CreateInstance(classType);

            foreach (PropertyInfo property in properties)
            {
                if (property.Name == "Name")
                    property.SetValue(instanceOfClass, "Chuck");
                if (property.Name == "Surname")
                    property.SetValue(instanceOfClass, "Norris");
                if (property.Name == "Age")
                    property.SetValue(instanceOfClass, (byte)65);
            }

            foreach (FieldInfo field in fileds)
            {
                if (field.Name == "_id")
                    field.SetValue(instanceOfClass, 234535);
            }

            foreach (MethodInfo method in methods)
            {
                if (method.Name == "PrintPersonInfo")
                    method.Invoke(instanceOfClass, null);
                if (method.Name == "GetId")
                    method.Invoke(instanceOfClass, null);
            }

            Console.ReadKey();
        }
    }


}
