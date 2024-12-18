using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    internal class Session
    {
        public required string Title { get; set; }
        public required string Date { get; set; }
        public required int Capacity { get; set; }
    }
}
