using System;

namespace GeometryClass
{
    public class Triangle
    {
        public static double AreaOfTriangle(double height, double triangleBase) => (triangleBase * height) / 2.0;

        public static double Hypoteneuse(double SideA, double SideB) => Math.Sqrt(SideA * SideA + SideB * SideB);
    }
}
