using Geometry.Cartesian.Points;
using Geometry.Cartesian.Primitives.LineSegments;

namespace Geometry.Cartesian.Primitives.Triangles
{
    /// <summary>
    /// Defines a triangle in 2D cartesian space.
    /// </summary>
    public class Triangle2D : ITriangle<IPoint2D>
    {
        /// <inheritdoc/>
        public IPoint2D V1 { get; }

        /// <inheritdoc/>
        public IPoint2D V2 { get; }

        /// <inheritdoc/>
        public IPoint2D V3 { get; }

        /// <inheritdoc/>
        public double Theta1 { get; }

        /// <inheritdoc/>
        public double Theta2 { get; }

        /// <inheritdoc/>
        public double Theta3 { get; }

        /// <inheritdoc/>
        public ILineSegment<IPoint2D> E1 { get; }

        /// <inheritdoc/>
        public ILineSegment<IPoint2D> E2 { get; }

        /// <inheritdoc/>
        public ILineSegment<IPoint2D> E3 { get; }

        private IPoint2D Centroid { get; }
        /// <inheritdoc/>
        IPoint ITriangle<IPoint2D>.Centroid => Centroid;

        /// <inheritdoc/>
        public double Area { get; }


        /// <summary>
        /// Create a new instance of <see cref="Triangle2D"/>.
        /// </summary>
        public Triangle2D(IPoint2D v1, IPoint2D v2, IPoint2D v3)
        {
            // Assign the vertices
            V1 = v1;
            V2 = v2;
            V3 = v3;

            // Assign the edges
            E1 = new LineSegment2D<IPoint2D>(V2, V3);
            E2 = new LineSegment2D<IPoint2D>(V3, V1);
            E3 = new LineSegment2D<IPoint2D>(V1, V2);

            // Assgine the centroid 
            var cx = (V1.X + V2.X + V3.X) / 3;
            var cy = (V1.Y + V2.Y + V3.Y) / 3;
            Centroid = new Point2D(cx, cy);

            /************************************************************************
             * Get the angles using law of cosines
             * If you know the length of Edge A, B, and C, you can calculate θa via:
             * θa = cos^-1((Eb^2 + Ec^2 - Ea^2) / (2 * Eb * Ec))
             ************************************************************************/
            Theta1 = TriangleMath.GetInteriorAngle(E2.Length, E3.Length, E1.Length);
            Theta2 = TriangleMath.GetInteriorAngle(E3.Length, E1.Length, E2.Length);
            Theta3 = TriangleMath.GetInteriorAngle(E1.Length, E2.Length, E3.Length);
        }
    }

    /// <summary>
    /// Defines a triangle in 2D cartesian space.
    /// </summary>
    /// <typeparam name="TVertex">
    /// A vertex in 2D cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="IPoint2D"/>.
    /// </typeparam>
    public class Triangle2D<TVertex> : ITriangle<TVertex>
        where TVertex : IPoint2D
    {
        /// <inheritdoc/>
        public TVertex V1 { get; }

        /// <inheritdoc/>
        public TVertex V2 { get; }

        /// <inheritdoc/>
        public TVertex V3 { get; }

        /// <inheritdoc/>
        public double Theta1 { get; }

        /// <inheritdoc/>
        public double Theta2 { get; }

        /// <inheritdoc/>
        public double Theta3 { get; }

        /// <inheritdoc/>
        public ILineSegment<TVertex> E1 { get; }

        /// <inheritdoc/>
        public ILineSegment<TVertex> E2 { get; }

        /// <inheritdoc/>
        public ILineSegment<TVertex> E3 { get; }

        private IPoint2D Centroid { get; }
        /// <inheritdoc/>
        IPoint ITriangle<TVertex>.Centroid => Centroid;

        /// <inheritdoc/>
        public double Area { get; }


        /// <summary>
        /// Create a new instance of <see cref="Triangle2D{TVertex}"/>.
        /// </summary>
        public Triangle2D(TVertex v1, TVertex v2, TVertex v3)
        {
            // Assign the vertices
            V1 = v1;
            V2 = v2;
            V3 = v3;

            // Assign the edges
            E1 = new LineSegment2D<TVertex>(V2, V3);
            E2 = new LineSegment2D<TVertex>(V3, V1);
            E3 = new LineSegment2D<TVertex>(V1, V2);

            // Assgine the centroid 
            var cx = (V1.X + V2.X + V3.X) / 3;
            var cy = (V1.Y + V2.Y + V3.Y) / 3;
            Centroid = new Point2D(cx, cy);

            /************************************************************************
             * Get the angles using law of cosines
             * If you know the length of Edge A, B, and C, you can calculate θa via:
             * θa = cos^-1((Eb^2 + Ec^2 - Ea^2) / (2 * Eb * Ec))
             ************************************************************************/
            Theta1 = TriangleMath.GetInteriorAngle(E2.Length, E3.Length, E1.Length);
            Theta2 = TriangleMath.GetInteriorAngle(E3.Length, E1.Length, E2.Length);
            Theta3 = TriangleMath.GetInteriorAngle(E1.Length, E2.Length, E3.Length);
        }
    }
}
