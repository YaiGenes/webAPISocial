using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public interface IBoss
    {
        public bool Anoying();
    
        public bool Scream
        {
            get; set;
        }
    }
}
