namespace Interpolant.Geometry.Cartesian.Coordinates
{
    /// <summary>
    /// Represents a coordinate in 1D cartesian space.
    /// </summary>
    /// <remarks>
    /// For more information, see <see cref="ICoordinate1D"/>.
    /// </remarks>
    internal readonly struct Coordinate1D : ICoordinate1D
    {
        /// <inheritdoc/>
        public double X { get; }


        /// <summary>
        /// Intializes a new instance of the see
        /// <see cref="Coordinate1D"/> struct.
        /// </summary>
        /// <param name="x"></param>
        public Coordinate1D(double x)
        {
            X = x;
        }
    }
}
