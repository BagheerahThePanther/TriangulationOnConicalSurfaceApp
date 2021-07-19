using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulationOnConicalSurfaceApp
{
    class Vector3D
    {
        private double x;
        private double y;
        private double z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get => x; }
        public double Y { get => y; }
        public double Z { get => z; }


        public double Length
        {
            get
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }
        }

        public double LengthSquared
        {
            get
            {
                return x * x + y * y + z * z;
            }
        }

        public void Normalize()
        {
            Vector3D tmp = this;
            tmp /= Math.Max(Math.Abs(x), Math.Max(Math.Abs(y), Math.Abs(z)));
            tmp /= Length;
            this.x = tmp.x;
            this.y = tmp.y;
            this.z = tmp.z;
        }

        public static double AngleBetween(Vector3D vector3D1, Vector3D vector3D2)
        {
            // Угол в радианах, вычисленный по формуле α = arccos[(a · b) / (|a| * |b|)]
            return Math.Acos(vector3D1 * vector3D2) / (vector3D1.Length * vector3D2.Length);
        }

        public static Vector3D operator -(Vector3D vector3D)
        {
            return new Vector3D(-vector3D.x, -vector3D.y, -vector3D.z);
        }

        public void Negate()
        {
            x = -x;
            y = -y;
            z = -z;
        }

        public static Vector3D operator +(Vector3D vector3D1, Vector3D vector3D2)
        {
            return new Vector3D(vector3D1.x + vector3D2.x, vector3D1.y + vector3D2.y, vector3D1.z + vector3D2.z);
        }

        public static Vector3D Add(Vector3D vector3D1, Vector3D vector3D2)
        {
            return new Vector3D(vector3D1.x + vector3D2.x, vector3D1.y + vector3D2.y, vector3D1.z + vector3D2.z);
        }

        public static Vector3D operator -(Vector3D vector3D1, Vector3D vector3D2)
        {
            return new Vector3D(vector3D1.x - vector3D2.x, vector3D1.y - vector3D2.y, vector3D1.z - vector3D2.z);
        }

        public static Vector3D Subtract(Vector3D vector3D1, Vector3D vector3D2)
        {
            return new Vector3D(vector3D1.x - vector3D2.x, vector3D1.y - vector3D2.y, vector3D1.z - vector3D2.z);
        }

        public static Vector3D operator *(Vector3D vector3D, double scalar)
        {
            return new Vector3D(vector3D.x * scalar, vector3D.y * scalar, vector3D.z * scalar);
        }

        public static Vector3D Multiply(Vector3D vector3D, double scalar)
        {
            return new Vector3D(vector3D.x * scalar, vector3D.y * scalar, vector3D.z * scalar);
        }

        public static Vector3D operator *(double scalar, Vector3D vector3D)
        {
            return new Vector3D(vector3D.x * scalar, vector3D.y * scalar, vector3D.z * scalar);
        }

        public static Vector3D Multiply(double scalar, Vector3D vector3D)
        {
            return new Vector3D(vector3D.x * scalar, vector3D.y * scalar, vector3D.z * scalar);
        }

        public static Vector3D operator /(Vector3D vector3D, double scalar)
        {
            return vector3D * (1.0 / scalar);
        }

        public static Vector3D Divide(Vector3D vector3D, double scalar)
        {
            return vector3D * (1.0 / scalar);
        }

        public static double operator *(Vector3D vector3D1, Vector3D vector3D2)
        {
            return vector3D1.x * vector3D2.x + vector3D1.y * vector3D2.y + vector3D1.z * vector3D2.z;
        }

        public static double Multiply(Vector3D vector3D1, Vector3D vector3D2)
        {
            return vector3D1.x * vector3D2.x + vector3D1.y * vector3D2.y + vector3D1.z * vector3D2.z;
        }

        public virtual string toString()
        {
            return "(" + x.ToString("0.000") + "; " + y.ToString("0.000") + "; " + z.ToString("0.000") + ")";
        }
    }
}
