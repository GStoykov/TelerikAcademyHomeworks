using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Point3D a = new Point3D(1, 1, 1);
        Point3D b = new Point3D(2, 2, 2);
        //Console.WriteLine(PointDistance.Distance(a, b));

        // Saving list of points in a text file 
        Path file = new Path();
        file.AddPointInList(a);
        file.AddPointInList(b);
        PathStorage.SavePaths(file);

        // Loading list of points from a text file
        List<Path> listOfPaths = PathStorage.LoadPaths();
        foreach (var path in listOfPaths)
        {
            Console.WriteLine("Point List:");
            foreach (var point in path.ListOfPoints)
            {
                Console.WriteLine(point);
            }
        }



    }
}
