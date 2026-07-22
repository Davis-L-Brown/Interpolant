using Geometry.Cartesian.Points;
using Geometry.Cartesian.Primitives.Vectors;

namespace Geometry.Cartesian.Primitives.LineSegments
{
    /// <summary>
    /// Represents a line segment in 3D cartesian space
    /// </summary>
    /// <typeparam name="TPoint">
    /// Represents a point in Cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="IPoint3D"/>.
    /// </typeparam>
    public class LineSegment3D<TPoint> : ILineSegment<TPoint>
        where TPoint : IPoint3D
    {
        /// <inheritdoc/>
        public TPoint Start { get; }

        /// <inheritdoc/>
        public TPoint End { get; }
        
        /// <summary>
        /// Gets the direction of the line segment.
        /// </summary>
        public Vector3D Direction => Vector3D.FromPoints(Start, End);

        /// <inheritdoc/>
        IVector ILineSegment<TPoint>.Direction => Direction;

        /// <inheritdoc/>
        public double Length =>
            Direction.Magnitude;

        /// <inheritdoc/>
        public double LengthSquared =>
            Direction.MagnitudeSquared;



        /// <summary>
        /// Create an instance of <see cref="LineSegment3D{TCoordinate}"/>.
        /// </summary>
        public LineSegment3D(TPoint start, TPoint end)
        {
            Start = start;
            End = end;
        }
    }


    /// <summary>
    /// Represents a line segment in 3D cartesian space
    /// </summary>
    public class LineSegment3D : LineSegment3D<IPoint3D>
    {
        /// <summary>
        /// Create an instance of <see cref="LineSegment3D{TCoordinate}"/>.
        /// </summary>
        public LineSegment3D(IPoint3D start, IPoint3D end)
            : base(start, end) { }
    }
}
