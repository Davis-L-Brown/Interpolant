using Geometry.Cartesian.Points;
using Geometry.Cartesian.Primitives.Vectors;

namespace Geometry.Cartesian.Primitives.LineSegments
{
    /// <summary>
    /// Represents a line segment in 1D cartesian space.
    /// </summary>
    /// <typeparam name="TPoint">
    /// Represents a point in Cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="IPoint1D"/>.
    /// </typeparam>
    public class LineSegment1D<TPoint> : ILineSegment<TPoint>
        where TPoint : IPoint1D
    {
        /// <inheritdoc/>
        public TPoint Start { get; }

        /// <inheritdoc/>
        public TPoint End { get; }

        /// <summary>
        /// Gets the direction of the line segment.
        /// </summary>
        public Vector1D Direction => Vector1D.FromPoints(Start, End);

        /// <inheritdoc/>
        IVector ILineSegment<TPoint>.Direction => Direction;

        /// <inheritdoc/>
        public double Length =>
            Direction.Magnitude;

        /// <inheritdoc/>
        public double LengthSquared =>
            Direction.MagnitudeSquared;


        /// <summary>
        /// Create an instance of <see cref="LineSegment1D{TCoordinate}"/>.
        /// </summary>
        public LineSegment1D(TPoint start, TPoint end)
        {
            Start = start;
            End = end;
        }
    }


    /// <summary>
    /// Represents a line segment in 1D cartesian space.
    /// </summary>
    public class LineSegment1D : LineSegment1D<IPoint1D>
    {
        /// <summary>
        /// Create an instance of <see cref="LineSegment1D{TCoordinate}"/>.
        /// </summary>
        public LineSegment1D(IPoint1D start, IPoint1D end)
            : base(start, end) { }
    }
}
