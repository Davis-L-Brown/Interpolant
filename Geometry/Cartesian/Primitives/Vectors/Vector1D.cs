using Geometry.Cartesian.Points;
using System;

namespace Geometry.Cartesian.Primitives.Vectors
{
    /// <summary>
    /// Defines a vector in 1D Cartesian space.
    /// </summary>
    public class Vector1D : IVector1D, IEquatable<Vector1D>
    {
        /// <inheritdoc/>
        public double X { get; }

        /// <inheritdoc/>
        public double Magnitude =>
            Math.Sqrt(MagnitudeSquared);

        /// <inheritdoc/>
        public double MagnitudeSquared =>
            X * X;


        /// <summary>
        /// Creates a new instance of <see cref="Vector1D"/>.
        /// </summary>
        public Vector1D(double x)
        {
            X = x;
        }


        /// <summary>
        /// Creates a new instance of <see cref="Vector1D"/>
        /// from two <see cref="IPoint1D"/>.
        /// </summary>
        public static Vector1D FromPoints(
            IPoint1D start,
            IPoint1D end)
        {
            return new Vector1D(
                end.X - start.X);
        }



        #region Operators
        /// <summary>
        /// Returns a normalized copy of the vector.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the vector has zero magnitude.
        /// </exception>
        public Vector1D Normalize()
        {
            double magnitude = Magnitude;

            if (magnitude == 0.0)
                throw new InvalidOperationException(
                    "A zero vector cannot be normalized.");

            return this / magnitude;
        }

        /// <summary>
        /// Calculate the dot product of two 2D vectors.
        /// </summary>
        public static double Dot(Vector1D left, Vector1D right)
        {
            return
                (left.X * right.X);
        }


        #region Vector addition/subtraction
        /// <summary>
        /// Add two vectors.
        /// </summary>
        public static Vector1D operator +(Vector1D left, Vector1D right)
        {
            return new Vector1D(
                left.X + right.X);
        }

        /// <summary>
        /// Subtract two vectors.
        /// </summary>
        public static Vector1D operator -(Vector1D left, Vector1D right)
        {
            return new Vector1D(
                left.X - right.X);
        }

        /// <summary>
        /// Multiply by negative 1.
        /// </summary>
        public static Vector1D operator -(Vector1D vector)
        {
            return new Vector1D(-vector.X);
        }
        #endregion

        #region Scalar Multiply/Divide
        /// <summary>
        /// Multiply a vector by a scalar.
        /// </summary>
        public static Vector1D operator *(Vector1D vector, double scalar)
        {
            return new Vector1D(
                vector.X * scalar);
        }

        /// <summary>
        /// Multiply a vector by a scalar.
        /// </summary>
        public static Vector1D operator *(double scalar, Vector1D vector)
        {
            return vector * scalar;
        }

        /// <summary>
        /// Divide a vector by a scalar.
        /// </summary>
        public static Vector1D operator /(Vector1D vector, double scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException(
                    "A vector cannot be divided by zero.");

            return new Vector1D(
                vector.X / scalar);
        }
        #endregion

        #region Equality
        /// <summary>
        /// Compare two vectors for equality.
        /// </summary>
        public static bool operator ==(Vector1D left, Vector1D right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compare two vectors for inequality.
        /// </summary>
        public static bool operator !=(Vector1D left, Vector1D right)
        {
            return !(left.Equals(right));
        }

        /// <summary>
        /// Compare two vectors for equality.
        /// </summary>
        public bool Equals(Vector1D other)
        {
            return
                X.Equals(other.X);
        }

        /// <summary>
        /// Compare two vectors for equality.
        /// </summary>
        public override bool Equals(object other)
        {
            return
                other is Vector1D &&
                Equals(other);
        }
        #endregion

        #endregion


        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 31) + X.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Get the vector as a string
        /// </summary>
        /// <returns>
        /// A string in the format &lt;X&gt;
        /// </returns>
        public override string ToString()
        {
            return $"<{X}>";
        }
    }
}
