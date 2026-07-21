namespace Geometry.Cartesian.Points
{
    /// <summary>
    /// Represents a point in 2D cartesian space.
    /// </summary>
    public class Point2D : IPoint2D
    {
        /// <summary>
        /// Get the X location of the 2D point.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Get the Y location of the 2D point.
        /// </summary>
        public double Y { get; }


        /// <summary>
        /// Initializes a new instance of <see cref="Point2D"/>.
        /// </summary>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
