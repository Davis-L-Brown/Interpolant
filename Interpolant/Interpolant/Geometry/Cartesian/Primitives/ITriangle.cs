using Interpolant.Geometry.Cartesian.Coordinates;
using Interpolant.Geometry.Cartesian.LineSegment;

namespace Interpolant.Geometry.Cartesian.Primitives
{
    /// <summary>
    /// Represents a triangle in 2D Cartesian space.
    /// </summary>
    /// <remarks>
    /// Can only exist in 2D space or higher (you can create a 2D
    /// triangle from 3D+ coordinates, but you will loose the
    /// additional dimensional data).
    /// </remarks>
    /// <typeparam name="TVertex">
    /// Represents a vertex of the triangle.
    /// <br/>
    /// Must be an inheritor of <see cref="ICoordinate2D"/>.
    /// </typeparam>
    /// <typeparam name="TEdge">
    /// Represents an edge of the triangle.
    /// <br/>
    /// Must be an inheritor of <see cref="ILineSegment{TVertex}"/>.
    /// </typeparam>
    internal interface ITriangle<out TVertex, out TEdge>
        where TVertex: ICoordinate2D
        where TEdge : ILineSegment<TVertex>
    {
        /// <summary>
        /// Coordinate location 1 or A.
        /// </summary>
        TVertex V1 { get; }

        /// <summary>
        /// Coordinate location 2 or B.
        /// </summary>
        TVertex V2 { get; }

        /// <summary>
        /// Coordinate location 3 or C.
        /// </summary>
        TVertex V3 { get; }


        /// <summary>
        /// The angle corresponding to vertex V1.
        /// </summary>
        double Theta1 { get; }

        /// <summary>
        /// The angle corresponding to vertex V2.
        /// </summary>
        double Theta2 { get; }

        /// <summary>
        /// The angle corresponding to vertex V3.
        /// </summary>
        double Theta3 { get; }


        /// <summary>
        /// The triangle edge opposite angle theta1.
        /// </summary>
        TEdge E1 { get; }

        /// <summary>
        /// The triangle edge opposite angle theta2.
        /// </summary>
        TEdge E2 { get; }

        /// <summary>
        /// The triangle edge opposite angle theta3.
        /// </summary>
        TEdge E3 { get; }


        /// <summary>
        /// The center of the triangle.
        /// </summary>
        ICoordinate2D Centroid { get; }
      
        /// <summary>
        /// The area of the triangle.
        /// </summary>
        double Area { get; }
    }
}
