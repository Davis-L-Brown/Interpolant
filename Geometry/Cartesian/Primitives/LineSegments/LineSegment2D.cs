using Geometry.Cartesian.Points;
using System;

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
        public TPoint StartPoint { get; }

        /// <inheritdoc/>
        public TPoint EndPoint { get; }

        /// <inheritdoc/>
        public double Length { get; }

        /// <inheritdoc/>
        public double LengthSquared { get; }

        /// <summary>
        /// Create an instance of <see cref="LineSegment2D{TCoordinate}"/>.
        /// </summary>
        public LineSegment2D(TPoint start, TPoint end)
        {
            StartPoint = start;
            EndPoint = end;

            double dx = end.X - start.X;
            double dy = end.Y - start.Y;

            LengthSquared = dx * dx + dy * dy;
            Length = Math.Sqrt(LengthSquared);
        }
    }

    /// <summary>
    /// Represents a line segment in 2D cartesian space.
    /// </summary>
    public class LineSegment2D : ILineSegment<IPoint2D>
    {
        /// <inheritdoc/>
        public IPoint2D StartPoint { get; }

        /// <inheritdoc/>
        public IPoint2D EndPoint { get; }

        /// <inheritdoc/>
        public double Length { get; }

        /// <inheritdoc/>
        public double LengthSquared { get; }

        /// <summary>
        /// Create an instance of <see cref="LineSegment2D{TCoordinate}"/>.
        /// </summary>
        public LineSegment2D(IPoint2D start, IPoint2D end)
        {
            StartPoint = start;
            EndPoint = end;

            double dx = end.X - start.X;
            double dy = end.Y - start.Y;

            LengthSquared = dx * dx + dy * dy;
            Length = Math.Sqrt(LengthSquared);
        }
    }
}
