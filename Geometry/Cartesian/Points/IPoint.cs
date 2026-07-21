namespace Geometry.Cartesian.Points
{
    /// <summary>
    /// Represents a point in cartesian space.
    /// </summary>
    public interface IPoint { }


    /// <summary>
    /// Represents a point in 1D space.
    /// </summary>
    public interface IPoint1D : IPoint
    {
        /// <summary>
        /// The X location of this cartesian point.
        /// </summary>
        double X { get; }
    }


    /// <summary>
    /// Represents a point in 2D space.
    /// </summary>
    public interface IPoint2D : IPoint
    {
        /// <summary>
        /// The X location of this cartesian point.
        /// </summary>
        double X { get; }

        /// <summary>
        /// The Y location of this cartesian point.
        /// </summary>
        double Y { get; }
    }


    /// <summary>
    /// Represents a point in 3D space.
    /// </summary>
    public interface IPoint3D : IPoint
    {
        /// <summary>
        /// The X location of this cartesian point.
        /// </summary>
        double X { get; }

        /// <summary>
        /// The Y location of this cartesian point.
        /// </summary>
        double Y { get; }

        /// <summary>
        /// The Z location of this cartesian point.
        /// </summary>
        double Z { get; }
    }
}
