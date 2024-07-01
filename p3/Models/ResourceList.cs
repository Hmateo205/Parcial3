using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3.Models
{
    public class ResourceList
    {
        public int count { get; set; }
        public string next { get; set; }

        public string previuos { get; set; }

        public List<ChuckInfo> results { get; set; }
    }
}
