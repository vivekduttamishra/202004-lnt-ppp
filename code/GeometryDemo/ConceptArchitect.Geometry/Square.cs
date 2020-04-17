using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Geometry
{
    public class RSquare : ProperRectangle
    {
        public RSquare(int side) : base(side,side) //passed as width,height
        {
        }
        //public override Orientation Orientation
        //{
        //    get
        //    {
        //        return 
        //    }
        //}

        public override Orientation Orientation
        {
            get
            {
                throw new Exception("Orientation is Not Supported");
            }
        }
    }
    public class Square: Rectangle
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side=side;
        }
        public override int Area { get { return Side * Side; } }
        public override int Perimeter { get { return 4 * Side; } }
        public override void Draw()
        {
            Console.WriteLine("Square[{0}] drawn",Side);
        }



    }

    
}
