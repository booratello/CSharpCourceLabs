using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphObjects
{
    internal class InvalidRadius : Exception
    {
        public double InvalidRadiusValue { get; }

        public InvalidRadius(double invalidRadiusValue, string message) : base(message)
        {
            this.InvalidRadiusValue = invalidRadiusValue;
        }

        public InvalidRadius(double invalidRadiusValue, string message, Exception innerException) : base(message, innerException)
        {
            this.InvalidRadiusValue = invalidRadiusValue;

        }
    }
}
