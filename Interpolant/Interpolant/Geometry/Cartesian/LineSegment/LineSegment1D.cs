using Interpolant.Geometry.Cartesian.Coordinates;
using System;

namespace Interpolant.Geometry.Cartesian.LineSegment
{
    /// <summary>
    /// Represents a line segment in 1D cartesian space.
    /// </summary>
    /// <typeparam name="TCoodinate">
    /// Represents a coordinate in Cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="ICoordinate1D"/>.
    /// </typeparam>
    internal readonly struct LineSegment1D<TCoodinate> : ILineSegment<TCoodinate>
        where TCoodinate : ICoordinate1D
    {
        /// <inheritdoc/>
        public TCoodinate StartPoint { get; }

        /// <inheritdoc/>
        public TCoodinate EndPoint { get; }

        /// <inheritdoc/>
        public double Length { get; }

        /// <inheritdoc/>
        public double LengthSquared { get; }


        /// <summary>
        /// Creates an instance of the <see cref="LineSegment1D{TCoodinate}"/> struct.
        /// </summary>
        public LineSegment1D(TCoodinate start, TCoodinate end)
        {
            StartPoint = start;
            EndPoint = end;
            Length = Math.Abs(EndPoint.X - StartPoint.X);
            LengthSquared = Length * Length;
        }
    }
}
