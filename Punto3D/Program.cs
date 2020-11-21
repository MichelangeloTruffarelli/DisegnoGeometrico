using Punto2D;
using System;

namespace Punto3D
{
    public class Punti3D : Punti2D
    {
        public int z { get; private set; }
        public Punti3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
