using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public class Test : BaseEntity
    {

        public string Name { get; set; }

        public Guid PatientID {get; set; }

        public Patient Patient { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
