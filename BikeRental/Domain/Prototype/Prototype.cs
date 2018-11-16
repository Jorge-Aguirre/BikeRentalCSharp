using System;

namespace Domain.Prototype
{
    public class Prototype
    {
        public int Primitive { get; set; }

        public DateTime Component { get; set; }

        public ComponentWithBackReference CircularReference { get; set; }

        public Prototype()
        { }

        public Prototype Clone()
        {
            return CircularReference.Prototype;
        }
    }
}
