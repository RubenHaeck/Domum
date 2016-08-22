using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domum.Data.Domain
{
    [Table("CONFIGURATION")]
    public class Configuration
    {
        [Key]
        public int ConfigID { get; set; }
        public string ConfigKey { get; set; }

        public string ConfigValue { get; set; }
        
    }
}
