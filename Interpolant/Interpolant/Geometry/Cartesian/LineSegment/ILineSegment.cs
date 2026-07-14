using Interpolant.Geometry.Cartesian.Coordinates;

namespace Interpolant.Geometry.Cartesian.LineSegment
{
    /// <summary>
    /// Represents a line segment with a start point and an end point.
    /// </summary>
    /// <typeparam name="TCoordinate">
    /// A <see cref="ICoordinate"/> implementation, denoting what dimension the
    /// line segment exists in.
    /// </typeparam>
    internal interface ILineSegment<out TCoordinate>
        where TCoordinate : ICoordinate1D
    {
        /// <summary>
        /// Get the starting <see cref="ICoordinate1D"/>.
        /// </summary>
        TCoordinate StartPoint { get; }

        /// <summary>
        /// Get the ending <see cref="ICoordinate1D"/>.
        /// </summary>
        TCoordinate EndPoint { get; }

        /// <summary>
        /// Get the length of the line segment.
        /// </summary>
        double Length { get; }

        /// <summary>
        /// Get the length of the line segment, squared.
        /// </summary>
        double LengthSquared { get; }
    }
}
