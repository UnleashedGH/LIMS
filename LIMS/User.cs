using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public class User : BaseEntity
    {
        public string Name {  get; set; }   
    }
}
