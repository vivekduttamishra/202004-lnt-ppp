using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Geometry
{
    public enum Orientation { Sleeping, Standing }
    public class ProperRectangle : Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public ProperRectangle(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override int Area
        {
            get
            {
                return Width * Height;
            }
        }

        public override int Perimeter
        {
            get
            {
                return 2 * (Width + Height);
            }
        }

        public override void Draw()
        {
            Console.WriteLine("{2} [{0},{1}] drawn", Width, Height,GetType().Name);                
        }

        public virtual Orientation Orientation
        {
            get
            {
                if (Width > Height)
                    return Orientation.Sleeping;
                else
                    return Orientation.Standing;
            }
        }

    }
   
}
