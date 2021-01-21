using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guppy.core.Models
{
    record RawMaterial
    {
        public string Form { get; init; }
        public string Specification { get; init; }
        public string Dimension1 { get; init; }
        public string Dimension2 { get; init; }
        public string Dimension3 { get; init; }
    }
}
