using Interpolant.Extrapolation;

namespace Interpolant.Options
{
    /// <summary>
    /// Defines the extrapolation options for an interpolator object.
    /// </summary>
    public interface IExtrapolationOptions
    {
        /// <summary>
        /// The consumer selected <see cref="ExtrapolationMethod"/>.
        /// </summary>
        /// <remarks>
        /// Specifies the method family that the interpolator will use to 
        /// evaluate query points outside of the convex hull.
        /// <br/>
        /// For more information on the available extrapolation methods, view
        /// <see cref="ExtrapolationMethod"/>.
        /// </remarks>
        ExtrapolationMethod Method { get; set; }


        /// <summary>
        /// Validate the extrapolation options for the interpolator object.
        /// </summary>
        void Validate();
    }
}
