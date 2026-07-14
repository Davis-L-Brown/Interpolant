using Interpolant.Geometry.Cartesian.Coordinates;
using System;

namespace Interpolant.Geometry.Cartesian.LineSegment
{
    /// <summary>
    /// Represents a line segment in 2D cartesian space.
    /// </summary>
    /// <typeparam name="TCoordinate">
    /// Represents a 2D coordinate in Cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="ICoordinate2D"/>.
    /// </typeparam>
    internal readonly struct LineSegment2D<TCoordinate> : ILineSegment<TCoordinate>
        where TCoordinate : ICoordinate2D
    {
        /// <inheritdoc/>
        public TCoordinate StartPoint { get; }

        /// <inheritdoc/>
        public TCoordinate EndPoint { get; }

        /// <inheritdoc/>
        public double Length { get; }

        /// <inheritdoc/>
        public double LengthSquared { get; }


        /// <summary>
        /// Creates an instance of the <see cref="LineSegment2D{TCoordinate}"/> struct.
        /// </summary>
        public LineSegment2D(TCoordinate start, TCoordinate end)
        {
            StartPoint = start;
            EndPoint = end;

            Length = Math.Sqrt(
                (EndPoint.X - StartPoint.X) * (EndPoint.X - StartPoint.X) +
                (EndPoint.Y - StartPoint.Y) * (EndPoint.Y - StartPoint.Y));

            LengthSquared = Length * Length;

        }
    }
}
