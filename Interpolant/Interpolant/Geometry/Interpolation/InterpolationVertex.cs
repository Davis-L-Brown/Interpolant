using Interpolant.Geometry.Cartesian.Coordinates;
using MIConvexHull;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpolant.Geometry.Interpolation
{
    internal sealed class InterpolationVertex : ICoordinate3D, IVertex
    {
        private readonly double[] _position;

        /// <summary>
        /// The position of the interpolation vertex.
        /// </summary>
        /// <remarks>
        /// Coordinates are indexed.
        /// <list type="bullet">
        /// <item>0 = X</item>
        /// <item>1 = Y</item>
        /// <item>2 = Z</item>
        /// </list>
        /// </remarks>
        public double[] Position => _position;

        /// <inheritdoc/>
        public double X => _position[0];

        /// <inheritdoc/>
        public double Y => _position[1];    

        /// <inheritdoc/>
        public double Z => _position[2];



        public InterpolationVertex(double x, double y, double z)
        {
            _position = new double[] { x, y, z };
        }
    }
}
