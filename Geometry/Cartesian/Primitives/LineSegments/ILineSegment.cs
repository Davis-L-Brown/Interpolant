using Geometry.Cartesian.Points;

namespace Geometry.Cartesian.Primitives.LineSegments
{
    /// <summary>
    /// Represents a line segment with a start point and an end point.
    /// </summary>
    /// <typeparam name="TPoint">
    /// An <see cref="IPoint"/> implementation, denoting what dimension the
    /// line segment exists in.
    /// </typeparam>
    public interface ILineSegment<out TPoint>
        where TPoint : IPoint
    {
        /// <summary>
        /// The starting <see cref="TPoint"/>.
        /// </summary>
        TPoint StartPoint { get; }

        /// <summary>
        /// The ending <see cref="TPoint"/>.
        /// </summary>
        TPoint EndPoint { get; }

        /// <summary>
        /// The length of the line segment.
        /// </summary>
        double Length { get; }

        /// <summary>
        /// The length of the line segment, squared.
        /// </summary>
        double LengthSquared { get; }
    }
}
