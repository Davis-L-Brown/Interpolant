namespace Geometry.Cartesian.Points
{
    /// <summary>
    /// Represents a point in 3D cartesian space.
    /// </summary>
    public class Point3D : IPoint3D
    {
        /// <summary>
        /// Get the X location of the 3D point.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Get the Y location of the 3D point.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Get the Z location of the 3D point.
        /// </summary>
        public double Z { get; }


        /// <summary>
        /// Initializes a new instance of <see cref="Point3D"/>.
        /// </summary>
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
