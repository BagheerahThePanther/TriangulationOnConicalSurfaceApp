using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulationOnConicalSurfaceApp
{
    class TriangulationManager
    {
        private ConicalSurface surface;

        public TriangulationManager()
        {
        }

        public TriangulationManager(double height, double radius)
        {
            initializeConicalSurface(height, radius);
        }

        public void initializeConicalSurface(double height, double radius)
        {
            surface = new ConicalSurface(height, radius);
        }

        public string printPoints(int numberOfSegments)
        {
            if(surface == null)
            {
                return "";
            }
            Vector3D[] points = surface.getPointsOfSegments(numberOfSegments);
            Vector3D topPoint = new Vector3D(0, 0, surface.Height);
            string result = getDescription(numberOfSegments); 

            for(int i = 0; i < numberOfSegments; i++)
            {
                result += "Треугольник " + i + " состоит из точек: " + points[i].toString() + " " + topPoint.toString() +
                    " " + points[(i+1) % numberOfSegments].toString() + Environment.NewLine;
            }
            return result;
        }

        public string printNormals()
        {
            if (surface.Points.Length < 1)
            {
                return "";
            }
            Vector3D[] points = surface.Points;
            Vector3D[] normals = surface.getSurfaceNormals();
            string result = getDescription(points.Length);

            for (int i = 0; i < points.Length; i++)
            {
                result += "Вектор из точки " + i + " имеет координаты " + normals[i].toString() + Environment.NewLine;
            }
            return result;
        }

        public string getDescription()
        {
            return "Параметры конической поверхности: " + Environment.NewLine +
                "Высота: " + surface.Height + "; радиус: " + surface.Radius;
        }

        public string getDescription(int numberOfSegments)
        {
            return getDescription() + "; Количество сегментов: " + numberOfSegments + Environment.NewLine;
        }
    }
}
