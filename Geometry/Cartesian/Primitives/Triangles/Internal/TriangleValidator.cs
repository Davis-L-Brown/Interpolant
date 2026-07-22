using System;

namespace Geometry.Cartesian.Primitives.Triangles.Internal
{
    internal static class TriangleValidator
    {
        /// <summary>
        /// Default relative tolerance used when determining whether a triangle
        /// is numerically degenerate.
        /// </summary>
        public const double DefaultDegeneracyTolerance = 1e-12;


        /// <summary>
        /// Determines whether a triangle is geometrically or numerically degenerate
        /// based on its doubled area relative to the square of its longest edge.
        /// </summary>
        /// <param name="doubledArea">
        /// The non-negative doubled area of the triangle.
        /// For a two-dimensional triangle, this is the absolute value of the scalar
        /// cross product of two adjacent edge vectors. For a three-dimensional
        /// triangle, this is the magnitude of their cross product.
        /// </param>
        /// <param name="e1LengthSquared">
        /// The non-negative squared length of the first edge.
        /// </param>
        /// <param name="e2LengthSquared">
        /// The non-negative squared length of the second edge.
        /// </param>
        /// <param name="e3LengthSquared">
        /// The non-negative squared length of the third edge.
        /// </param>
        /// <param name="relativeTolerance">
        /// The non-negative relative tolerance used to determine whether the
        /// triangle's area is numerically insignificant relative to its scale.
        /// The area threshold is calculated by multiplying this value by the
        /// squared length of the triangle's longest edge.
        /// </param>
        /// <returns>
        /// <see langword="true"/> - when the triangle has zero or numerically
        /// insignificant area relative to its longest edge.
        /// <br/>
        /// <see langword="false"/> - otherwise
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="relativeTolerance"/> or
        /// <paramref name="doubledArea"/> is negative, NaN, or infinite.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when any squared edge length is negative, NaN, or infinite.
        /// </exception>
        public static bool IsDegenerate(
            double doubledArea,
            double e1LengthSquared,
            double e2LengthSquared,
            double e3LengthSquared,
            double relativeTolerance)
        {
            if (!IsFiniteNonNegative(relativeTolerance))
                throw new ArgumentOutOfRangeException(
                    nameof(relativeTolerance),
                    "The degeneracy tolerance must be finite and non-negative.");

            if (!IsFiniteNonNegative(doubledArea))
                throw new ArgumentOutOfRangeException(
                    nameof(doubledArea),
                    "The triangle must have a finite and non-negative doubled area.");

            if (!IsFiniteNonNegative(e1LengthSquared) ||
                !IsFiniteNonNegative(e2LengthSquared) ||
                !IsFiniteNonNegative(e3LengthSquared))
                throw new ArgumentException(
                    "Triangle edges must be finite and non-negative.");

            double scale2d = Math.Max(
                Math.Max(e1LengthSquared, e2LengthSquared),
                e3LengthSquared);

            double areaTolerance = relativeTolerance * scale2d;

            return doubledArea <= areaTolerance;
        }


        /// <summary>
        /// Helper method to ensure that an edge length is
        /// <list type="bullet">
        /// <item>A real value number (not <see cref="Double.NaN"/>)</item>
        /// <item><paramref name="value"/> &gt; zero</item>
        /// <item>A finite number</item>
        /// </list>
        /// </summary>
        private static bool IsFinitePositive(double value)
        {
            return
                !double.IsNaN(value) &&
                !double.IsInfinity(value) &&
                value > 0.0;
        }

        /// <summary>
        /// Helper method to ensure that an edge length is
        /// <list type="bullet">
        /// <item>A real value number (not <see cref="Double.NaN"/>)</item>
        /// <item><paramref name="value"/> &gt;= zero</item>
        /// <item>A finite number</item>
        /// </list>
        /// </summary>
        private static bool IsFiniteNonNegative(double value)
        {
            return
                !double.IsNaN(value) &&
                !double.IsInfinity(value) &&
                value >= 0.0;
        }
    }
}
