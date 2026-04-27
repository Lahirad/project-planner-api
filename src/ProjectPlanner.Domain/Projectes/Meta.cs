using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Domain.Projectes
{
    public sealed  class Meta
    {
        public string RequestId { get; set; }
        public string Timestamp { get; set; }
        public string Version { get; set; }

        public static Meta Create(string version)
        {
            return new Meta
            {
                RequestId = Guid.NewGuid().ToString(),
                Timestamp = DateTime.UtcNow.ToString("o"),
                Version = version
            };
        }
    }
}
