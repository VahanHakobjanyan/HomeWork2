using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LMS
{
    internal class FacultyMember : Member
    {
        public string Department { get; private set; }

        public FacultyMember(string name, string id, string department) : base(name, id)
        {
            Department = department;
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Notification for {Name} from {Department} department:\n{message}");
        }
    }
}
