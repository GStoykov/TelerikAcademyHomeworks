using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameMethods.GetFileExtension("example"));
            Console.WriteLine(FileNameMethods.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameMethods.GetFileExtension("example.new.pdf"));
                              
            Console.WriteLine(FileNameMethods.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameMethods.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameMethods.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Geometry2D.CalculateDistance2D(1, -2, 3, 4));

            Console.WriteLine("Distance in the 3D space = {0:f2}", Geometry3D.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid cuboid = new Cuboid(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", cuboid.CalculateVolume());

            Console.WriteLine("Diagonal XYZ = {0:f2}", Geometry3D.CalculateDiagonalXYZ(cuboid.Width, cuboid.Height, cuboid.Depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Geometry2D.CalculateDiagonalXY(cuboid.Width, cuboid.Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Geometry2D.CalculateDiagonalXZ(cuboid.Width, cuboid.Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Geometry2D.CalculateDiagonalYZ(cuboid.Height, cuboid.Depth));
        }
    }
}
