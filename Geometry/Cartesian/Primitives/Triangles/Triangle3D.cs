using Geometry.Cartesian.Points;
using Geometry.Cartesian.Primitives.LineSegments;

namespace Geometry.Cartesian.Primitives.Triangles
{
    /// <summary>
    /// Defines a triangle in 3D cartesian space.
    /// </summary>
    public class Triangle3D : ITriangle<IPoint3D>
    {
        /// <inheritdoc/>
        public IPoint3D V1 { get; }

        /// <inheritdoc/>
        public IPoint3D V2 { get; }

        /// <inheritdoc/>
        public IPoint3D V3 { get; }

        /// <inheritdoc/>
        public double Theta1 { get; }

        /// <inheritdoc/>
        public double Theta2 { get; }

        /// <inheritdoc/>
        public double Theta3 { get; }

        /// <inheritdoc/>
        public ILineSegment<IPoint3D> E1 { get; }

        /// <inheritdoc/>
        public ILineSegment<IPoint3D> E2 { get; }

        /// <inheritdoc/>
        public ILineSegment<IPoint3D> E3 { get; }

        private IPoint3D Centroid { get; }
        /// <inheritdoc/>
        IPoint ITriangle<IPoint3D>.Centroid => Centroid;

        /// <inheritdoc/>
        public double Area { get; }


        /// <summary>
        /// Create a new instance of <see cref="Triangle3D"/>.
        /// </summary>
        public Triangle3D(IPoint3D v1, IPoint3D v2, IPoint3D v3)
        {
            // Assign the vertices
            V1 = v1;
            V2 = v2;
            V3 = v3;

            // Assign the edges
            E1 = new LineSegment3D<IPoint3D>(V2, V3);
            E2 = new LineSegment3D<IPoint3D>(V3, V1);
            E3 = new LineSegment3D<IPoint3D>(V1, V2);

            // Assgine the centroid 
            var cx = (V1.X + V2.X + V3.X) / 3;
            var cy = (V1.Y + V2.Y + V3.Y) / 3;
            var cz = (V1.Z + V2.Z + V3.Z) / 3;
            Centroid = new Point3D(cx, cy, cz);

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
    /// Defines a triangle in 3D cartesian space.
    /// </summary>
    /// <typeparam name="TVertex">
    /// A vertex in 3D cartesian space.
    /// <br/>
    /// Must be an inheritor of <see cref="IPoint3D"/>.
    /// </typeparam>
    public class Triangle3D<TVertex> : ITriangle<TVertex>
        where TVertex : IPoint3D
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

        private IPoint3D Centroid { get; }
        /// <inheritdoc/>
        IPoint ITriangle<TVertex>.Centroid => Centroid;

        /// <inheritdoc/>
        public double Area { get; }


        /// <summary>
        /// Create a new instance of <see cref="Triangle3D{TVertex}"/>.
        /// </summary>
        public Triangle3D(TVertex v1, TVertex v2, TVertex v3)
        {
            // Assign the vertices
            V1 = v1;
            V2 = v2;
            V3 = v3;

            // Assign the edges
            E1 = new LineSegment3D<TVertex>(V2, V3);
            E2 = new LineSegment3D<TVertex>(V3, V1);
            E3 = new LineSegment3D<TVertex>(V1, V2);

            // Assgine the centroid 
            var cx = (V1.X + V2.X + V3.X) / 3;
            var cy = (V1.Y + V2.Y + V3.Y) / 3;
            var cz = (V1.Z + V2.Z + V3.Z) / 3;
            Centroid = new Point3D(cx, cy, cz);

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
