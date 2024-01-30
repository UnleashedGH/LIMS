using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public class Patient : BaseEntity
    {


        public string Name { get; set; }

        //navigation property
        public virtual ICollection<Test> Tests { get; set; }
    }
}
