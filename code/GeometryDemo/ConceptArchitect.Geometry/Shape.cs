using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Geometry
{
    public abstract class Rectangle
    {
        public abstract int Area { get; }
        public abstract int Perimeter { get; }
        public abstract void Draw();

        
    }
}
