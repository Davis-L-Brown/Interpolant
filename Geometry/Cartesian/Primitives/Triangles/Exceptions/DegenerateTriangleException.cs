using System;

namespace Geometry.Cartesian.Primitives.Triangles.Exceptions
{
    public class DegenerateTriangleException : ArgumentException
    {
        private const string DefaultMessage =
            "The supplied vertices form a degenerate or " +
            "numerically near-degenerate traingle.";

        public DegenerateTriangleException() : base(DefaultMessage) { }

        public DegenerateTriangleException(string messsage) : base (messsage) { }
    }
}
