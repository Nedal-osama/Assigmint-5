using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmint_5.First_project
{
    public class Point3D:IComparable,ICloneable
    {
        private int x, y, z;

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Point3D p = obj as Point3D;
            if (p == null) throw new ArgumentException("Object is not a Point3D");
            if (x < p.x) return -1;
            if (x > p.x) return 1;
            if (y < p.y) return -1;
            if (y > p.y) return 1;
            if (z < p.z) return -1;
            if (z > p.z) return 1;
            return 0;
        }

        public object Clone()
        {
            return new Point3D(x, y, z);
        }
}
}
