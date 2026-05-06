using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Application.Exceptions
{
    public sealed class ConcurrencyException : Exception
    {
        public ConcurrencyException(string? message, Exception? innerException) : base(message, innerException)
        {

        }   
    }
}
    