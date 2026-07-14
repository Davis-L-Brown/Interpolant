using Interpolant.Geometry.Cartesian.Coordinates;
using System;

namespace Interpolant.Geometry.Cartesian.LineSegment
{
    /// <summary>
    /// Represents a line segment in 3D cartesian space.
    /// </summary>
    /// <typeparam name="TCoordinate">
    /// Represents a coordinate in 3D cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="ICoordinate3D"/>.
    /// </typeparam>
    internal readonly struct LineSegment3D<TCoordinate> : ILineSegment<TCoordinate> 
        where TCoordinate : ICoordinate3D
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
        /// Initializes an instance of the <see cref="LineSegment3D{TCoordinate}"/> struct.
        /// </summary>
        public LineSegment3D(TCoordinate start, TCoordinate end)
        {
            StartPoint = start;
            EndPoint = end;

            Length = Math.Sqrt(
                (EndPoint.X - StartPoint.X) * (EndPoint.X - StartPoint.X) + 
                (EndPoint.Y - StartPoint.Y) * (EndPoint.Y - StartPoint.Y) +
                (EndPoint.Z - StartPoint.Z) * (EndPoint.Z - StartPoint.Z));

            LengthSquared = Length * Length;
        }
    }
}
