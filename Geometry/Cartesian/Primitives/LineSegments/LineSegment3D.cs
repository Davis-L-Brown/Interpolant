using Geometry.Cartesian.Points;
using System;

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
    internal class LineSegment3D<TPoint> : ILineSegment<TPoint>
        where TPoint : IPoint3D
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
        /// Create an instance of <see cref="LineSegment3D{TCoordinate}"/>.
        /// </summary>
        public LineSegment3D(TPoint start, TPoint end)
        {
            StartPoint = start;
            EndPoint = end;

            double dx = end.X - start.X;
            double dy = end.Y - start.Y;
            double dz = end.Z - start.Z;

            LengthSquared = dx * dx + dy * dy + dz * dz;
            Length = Math.Sqrt(LengthSquared);
        }
    }


    /// <summary>
    /// Represents a line segment in 3D cartesian space
    /// </summary>
    public class LineSegment3D : ILineSegment<IPoint3D>
    {
        /// <inheritdoc/>
        public IPoint3D StartPoint { get; }

        /// <inheritdoc/>
        public IPoint3D EndPoint { get; }

        /// <inheritdoc/>
        public double Length { get; }

        /// <inheritdoc/>
        public double LengthSquared { get; }


        /// <summary>
        /// Create an instance of <see cref="LineSegment3D{TCoordinate}"/>.
        /// </summary>
        public LineSegment3D(IPoint3D start, IPoint3D end)
        {
            StartPoint = start;
            EndPoint = end;

            double dx = end.X - start.X;
            double dy = end.Y - start.Y;
            double dz = end.Z - start.Z;

            LengthSquared = dx * dx + dy * dy + dz * dz;
            Length = Math.Sqrt(LengthSquared);
        }
    }
}
