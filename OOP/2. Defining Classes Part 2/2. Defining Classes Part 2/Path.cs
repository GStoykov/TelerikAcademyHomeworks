// Create a class Path to hold a sequence of points in the 3D space. 
// Create a static class PathStorage with static methods to save and load paths from a text file. 
// Use a file format of your choice.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Path
{
    private List<Point3D> pointsList = new List<Point3D>();

    public List<Point3D> ListOfPoints
    {
        get { return pointsList; }

    }

    public void AddPointInList(Point3D point)
    {
        ListOfPoints.Add(point);
    }
}