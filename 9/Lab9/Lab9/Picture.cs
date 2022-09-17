using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Picture : IDraw
    {
        private List<Triangle> triangles;

        public Picture()
        {
            triangles = new();
        }

        public Picture(int length)
        {
            triangles = new(length);
        }

        public void AddTriangle(Triangle triangle)
        {
            triangles.Add(triangle);
        }

        public void RemoveTriangle(string name)
        {
            for (int i = triangles.Count - 1; i >= 0; i--)
                if (triangles[i].ObjectName == name) triangles.RemoveAt(i);
        }
        public void RemoveTriangle(Triangle triangleObj)
        {
            var type = triangleObj.GetType();
            for (int i = triangles.Count - 1; i >= 0; i--)
                if (triangles[i].GetType() == type) triangles.RemoveAt(i);
        }

        public void RemoveTriangle(double area)
        {
            for (int i = triangles.Count - 1; i >= 0; i--)
                if (triangles[i].Area() > area) triangles.RemoveAt(i);
        }

        public int Count()
        {
            return triangles.Count;
        }

        public Triangle At(int index)
        {
            if (index < 0 || index >= triangles.Count)
                return null;

            return triangles[index];
        }

        public void Draw()
        {
            foreach (Triangle triangle in triangles)
                triangle.Draw();
        }
    }
}
