using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public class BaseEntity
    {

        [Key]
        public Guid id{ get; set; }
        public DateTime CreatedAt => DateTime.Now;
        public DateTime UpdatedAt {get; set; }
    }
}
