using System;

namespace Geometry.Cartesian.Primitives.Triangles
{
    public static class TriangleMath
    {
        /// <summary>
        /// Hepler used to get an angle in the triangle.
        /// </summary>
        /// <remarks>
        /// Uses the law of cosines to calculate the edge.
        /// </remarks>
        /// <param name="leftAdjacentLength">
        /// The length of the edge left-adjacent to the angle being calculated.
        /// </param>
        /// <param name="rightAdjacentLength">
        /// The length of the edge right-adjacent to the angle being calculated.
        /// </param>
        /// <param name="oppositeLength">
        /// The length of the edge opposite the angle being calculated.
        /// </param>
        /// <returns>
        /// The calculated angle.
        /// </returns>
        public static double GetInteriorAngle(
            double leftAdjacentLength,
            double rightAdjacentLength,
            double oppositeLength)
        {
            if (!IsFinitePositive(leftAdjacentLength))
                throw new ArgumentOutOfRangeException(
                    nameof(leftAdjacentLength),
                    "Left adjacent edge length must be finite and greater than zero.");

            if (!IsFinitePositive(rightAdjacentLength))
                throw new ArgumentOutOfRangeException(
                    nameof(rightAdjacentLength),
                    "Right adjacent edge length must be finite and greater than zero.");

            if (!IsFinitePositive(oppositeLength))
                throw new ArgumentOutOfRangeException(
                    nameof(oppositeLength),
                    "Opposite edge length must be finite and greater than zero.");

            if (oppositeLength >= leftAdjacentLength + rightAdjacentLength)
                throw new ArgumentException(
                    "The supplied edge lengths form a degenerate triangle: " +
                    $"{oppositeLength} > = {leftAdjacentLength} + {rightAdjacentLength}");

            double cosine =
                (leftAdjacentLength * leftAdjacentLength +
                 rightAdjacentLength * rightAdjacentLength -
                 oppositeLength * oppositeLength) /
                (2.0 * leftAdjacentLength * rightAdjacentLength);

            cosine = Math.Min(1.0, Math.Max(-1.0, cosine));

            return Math.Acos(cosine);
        }


        /// <summary>
        /// Helper method to ensure that an edge length is
        /// <list type="bullet">
        /// <item>A real value number (not <see cref="Double.NaN"/>)</item>
        /// <item>Greater than zero</item>
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
    }
}
