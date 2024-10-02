using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagination
{
    public class Animal
    {
        public bool IsPet { get; set; }
        public AnimalType Type { get; set; }
        public AnimalColor Color { get; set; }
    }

    public enum AnimalType
    {
        None,
        Cat,
        Dog,
        Bird,
        Fish
    }

    public enum AnimalColor
    {
        Black,
        White,
        Blue,
        Red,
        Green,
        Yellow,
    }
}
