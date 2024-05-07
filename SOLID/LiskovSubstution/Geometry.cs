using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public interface ICalculatableArea
    {
        int GetArea();
    }
    public class Geometry
    {
        public static ICalculatableArea GetRectangle(int unit1, int? unit2=null)
        {
            //hayal edin: Bir biçimde kare döndürüyorsunuz:
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }

            return new Square { UnitLength = unit1 };
            
        }
    }

    public class Rectangle : ICalculatableArea
    {
        public int Width { get; set; }
        public int Height { get; set; }

       public int GetArea() => Width * Height;
    }

    public class  Square : ICalculatableArea //: Rectangle
    {
        public int UnitLength { get; set; }
        public int GetArea()=>UnitLength * UnitLength;
    }

    public class Circle : ICalculatableArea
    {
        public int Radius { get; set; }
        public int GetArea()
        {
           return (int)(Math.PI * Math.Pow(Radius, 2));
        }
    }
}
