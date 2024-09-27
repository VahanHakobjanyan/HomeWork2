using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class StudentMember : Member
    {
        public string Grade { get; private set; }

        public StudentMember(string name, string id, string grade) : base(name, id)
        {
            Grade = grade;
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Notification for student {Name} from {Grade}:\n{message}");
        }
    }
}
