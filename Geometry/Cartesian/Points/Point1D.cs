namespace Geometry.Cartesian.Points
{
    /// <summary>
    /// Represents a point in 1D cartesian space.
    /// </summary>
    public class Point1D : IPoint1D
    {
        /// <summary>
        /// Get the X location of the 1D point.
        /// </summary>
        public double X { get; }


        /// <summary>
        /// Initializes a new instance of <see cref="Point1D"/>.
        /// </summary>
        public Point1D(double x)
        {
            X = x;
        }
    }
}