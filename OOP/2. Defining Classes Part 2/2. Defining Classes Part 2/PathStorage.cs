// Create a static class PathStorage with static methods to save and load paths from a text file. 
// Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class PathStorage
{
    Path pointsList = new Path();

    // Save path Method
    public static void SavePaths(Path path)
    {
        StreamWriter writer = new StreamWriter("../../PointsPaths.txt");
        using (writer)
        {
            foreach (var point in path.ListOfPoints)
            {
                writer.WriteLine(point);
            }
        }
    }

    // Load path Method
    public static List<Path> LoadPaths()
    {
        Path newPath = new Path();
        List<Path> listOfPaths = new List<Path>();
        StreamReader reader = new StreamReader("../../LoadPoints.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line != "end")
                {
                    Point3D point = new Point3D();
                    string[] points = line.Split(',');
                    point.x = int.Parse(points[0]);
                    point.y = int.Parse(points[1]);
                    point.z = int.Parse(points[2]);
                    newPath.AddPointInList(point);
                }
                else
                {
                    listOfPaths.Add(newPath);
                    newPath = new Path();
                }
                line = reader.ReadLine();                
            }
        }
        return listOfPaths;
    }
}
