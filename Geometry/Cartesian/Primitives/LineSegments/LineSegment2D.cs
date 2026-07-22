using Geometry.Cartesian.Points;
using Geometry.Cartesian.Primitives.Vectors;

namespace Geometry.Cartesian.Primitives.LineSegments
{
    /// <summary>
    /// Represents a line segment in 2D cartesian space.
    /// </summary>
    /// <typeparam name="TPoint">
    /// Represents a point in Cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="IPoint2D"/>.
    /// </typeparam>
    public class LineSegment2D<TPoint> : ILineSegment<TPoint>
        where TPoint : IPoint2D
    {
        /// <inheritdoc/>
        public TPoint Start { get; }

        /// <inheritdoc/>
        public TPoint End { get; }

        /// <summary>
        /// Gets the direction of the line segment.
        /// </summary>
        public Vector2D Direction => Vector2D.FromPoints(Start, End);

        /// <inheritdoc/>
        IVector ILineSegment<TPoint>.Direction => Direction;

        /// <inheritdoc/>
        public double Length =>
            Direction.Magnitude;

        /// <inheritdoc/>
        public double LengthSquared =>
            Direction.MagnitudeSquared;


        /// <summary>
        /// Create an instance of <see cref="LineSegment2D{TCoordinate}"/>.
        /// </summary>
        public LineSegment2D(TPoint start, TPoint end)
        {
            Start = start;
            End = end;
        }
    }

    /// <summary>
    /// Represents a line segment in 2D cartesian space.
    /// </summary>
    public class LineSegment2D : LineSegment2D<IPoint2D>
    {
        /// <summary>
        /// Create an instance of <see cref="LineSegment2D{TCoordinate}"/>.
        /// </summary>
        public LineSegment2D(IPoint2D start, IPoint2D end)
            : base(start, end) { }
    }
}
