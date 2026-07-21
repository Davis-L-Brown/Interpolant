using Geometry.Cartesian.Points;
using System;

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
    internal class LineSegment1D<TPoint> : ILineSegment<TPoint>
        where TPoint : IPoint1D
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
        /// Create an instance of <see cref="LineSegment1D{TCoordinate}"/>.
        /// </summary>
        public LineSegment1D(TPoint start, TPoint end)
        {
            StartPoint = start;
            EndPoint = end;

            double dx = end.X - start.X;

            LengthSquared = dx * dx;
            Length = Math.Sqrt(LengthSquared);
        }
    }


    /// <summary>
    /// Represents a line segment in 1D cartesian space.
    /// </summary>
    public class LineSegment1D : ILineSegment<IPoint1D>
    {
        /// <inheritdoc/>
        public IPoint1D StartPoint { get; }

        /// <inheritdoc/>
        public IPoint1D EndPoint { get; }

        /// <inheritdoc/>
        public double Length { get; }

        /// <inheritdoc/>
        public double LengthSquared { get; }

        /// <summary>
        /// Create an instance of <see cref="LineSegment1D{TCoordinate}"/>.
        /// </summary>
        public LineSegment1D(IPoint1D start, IPoint1D end)
        {
            StartPoint = start;
            EndPoint = end;

            double dx = end.X - start.X;

            LengthSquared = dx * dx;
            Length = Math.Sqrt(LengthSquared);
        }
    }
}
