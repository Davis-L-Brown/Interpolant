using Interpolant.Options.Enums;

namespace Interpolant.Options
{
    /// <summary>
    /// Defines input options for an interpolator object.
    /// </summary>
    public sealed class InputOptions
    {
        /// <summary>
        /// Gets the duplicate coordinate specified by the consumer.
        /// </summary>
        /// <remarks>
        /// Specifies how to handle duplicate input (x,y) coordinates
        /// passed into the interpolant.
        /// </remarks>
        public DuplicateCoordinatePolicy DuplicatePolicy { get; set; }


        /// <summary>
        /// Create an instance of the <see cref="InputOptions"/> class.
        /// </summary>
        /// <param name="policy">
        /// How the interpolant should handle duplicate input (x,y) measurements.
        /// <br/>
        /// Defaults to <see cref="DuplicateCoordinatePolicy.AverageZ"/>.
        /// </param>
        public InputOptions(
            DuplicateCoordinatePolicy policy = DuplicateCoordinatePolicy.AverageZ)
        {
            DuplicatePolicy = policy;
        }
    }
}
