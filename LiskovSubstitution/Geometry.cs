using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public interface IArea
    {
        int GetArea();
    }
    public class Geometry
    {
        public static IArea GetAreaOfObject(int length1, int? length2=null)
        {
            if (length2 == null)
            {
                return new Square { Edge = length1 };
            }
            else
            {
                return new Rectangle { Width = length1, Height = length2.Value };
            }
        }
    }

    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea() => Width * Height;

    }

    public class Square : IArea //: Rectangle
    {
        //private int _width;
        //private int _height;

        //public override int Width
        //{
        //    get => _width;
        //    set
        //    {
        //        _width = value;
        //        _height = value;
        //    }
        //}

        //public override int Height
        //{
        //    get => _height;
        //    set
        //    {
        //        _width = value;
        //        _height = value;
        //    }
        //}

        public int Edge { get; set; }

        public int GetArea() => Edge * Edge;
    }
}
