// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
// Implement the ToString() to enable printing a 3D point.

// Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
// Add a static property to return the point O.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Point3D
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    static public readonly Point3D pointZero = new Point3D(0, 0, 0);

    public Point3D(int x, int y, int z) :this()
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendFormat("x = {0}", this.x);
        text.AppendLine();
        text.AppendFormat("y = {0}", this.y);
        text.AppendLine();
        text.AppendFormat("z = {0}", this.z);
        text.AppendLine();
        return text.ToString();
    }

}

