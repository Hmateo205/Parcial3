using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3.Layouts
{
    internal class ResourceList
    {
        public int count { get; set; }
        public string next { get; set; }

        public string previuos { get; set; }

        public List<ChuckNorris> results { get; set; }
    }
}
