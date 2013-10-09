//Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class PointDistance
{
    public static double Distance(Point3D pointA, Point3D pointB)
    {
        double distance = 0;
        distance = Math.Sqrt(Math.Pow((pointA.x - pointB.x), 2) +
         Math.Pow((pointA.y - pointB.y), 2) + Math.Pow((pointA.z - pointB.z), 2));
        return distance;
    }
}
