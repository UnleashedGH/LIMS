using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public class Result : BaseEntity
    {

        public Test Test { get; set; }  
        public Guid TestId { get; set; }
        public string Type {  get; set; }
    }
}
