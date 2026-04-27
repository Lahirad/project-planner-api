using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Abstractions
{
    public sealed class Error
    {
        public string Field { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
    }
}
