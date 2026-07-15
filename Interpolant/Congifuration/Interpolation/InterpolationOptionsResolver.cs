using Interpolant.Congifuration.Interpolation.Kriging;
using Interpolant.Congifuration.Interpolation.RadialBasis;
using Interpolant.Congifuration.Interpolation.Simplicial;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpolant.Congifuration.Interpolation
{
    internal static class InterpolationOptionsResolver
    {

        public static IInterpolationOptions Resolve(IInterpolationOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));


            if (options is SimplicialOptions simplicial)
            {
                simplicial.Validate();
                return simplicial;
            }


            if (options is RadialBasisOptions radialBasis)
            {
                radialBasis.Validate();
                return radialBasis;
            }


            if (options is KrigingOptions kriging)
            {
                kriging.Validate();
                return kriging;
            }

            throw new NotSupportedException(
                $"Interpolation options of type " +
                $"'{options.GetType().FullName}' are not supported.");
        }
    }
}