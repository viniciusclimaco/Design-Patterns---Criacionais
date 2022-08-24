using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Acessories
{
    public class OriginCooffe
    {
        public string Country { get; set; }

        public OriginCooffe Clone()
        {
            return (OriginCooffe)this.MemberwiseClone();
        }
    }
}
