using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    internal class Conference
    {
        public required string Name { get; set; }
        public required string Date { get; set; }
        public required string Venue { get; set; }
        public required string Description { get; set; }

    }
}
