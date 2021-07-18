using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulationOnConicalSurfaceApp
{
    class ConicalSurface
    {
        private readonly double height; // Высота конуса
        private readonly double radius; // Радиус конуса
        private Vector3D[] points; // Массив точек
        private Vector3D[] normals; // Массив векторов нормали

        public ConicalSurface(double height, double radius)
        {
            this.height = height;
            this.radius = radius;
        }

        internal double Height { get => height; }
        internal double Radius { get => radius; }
        internal Vector3D[] Points { get => points; }
        internal Vector3D[] Normals { get => normals; set => normals = value; }

        public Vector3D[] getPointsOfSegments(int numberOfSegments)
        {
            // Pi: { R * cos(2PI * i / N), R * sin(2PI * i / N), 0} , i = 0, ... N - 1
            points = new Vector3D[numberOfSegments];
            for (int i = 0; i < numberOfSegments; i++)
            {
                points[i] = new Vector3D(radius * Math.Cos(2 * Math.PI * i / numberOfSegments), 0,
                    radius * Math.Sin(2 * Math.PI * i / numberOfSegments));
            }
            return points;
        }

        public Vector3D[] getSurfaceNormals()
        {
            // y-координата векторов всегда одинакова и зависит от соотношения радиуса и высоты конуса
            double hypotenuse = Math.Sqrt(radius * radius + height * height);
            double Y = radius / hypotenuse;
            normals = new Vector3D[points.Length];
            int numberOfSegments = points.Length;

            // x- и z-координаты зависят от конкретной точки
            for(int i = 0; i < numberOfSegments; i++)
            {
                normals[i] = new Vector3D(height * Math.Cos(2 * Math.PI * i / numberOfSegments) / hypotenuse, Y,
                    height * Math.Sin(2 * Math.PI * i / numberOfSegments) / hypotenuse);
            }
            return normals;
        }
    }
}
