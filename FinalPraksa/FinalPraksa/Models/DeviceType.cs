using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPraksa.Models
{
    public class DeviceType
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }
        public int DeviceId { get; set; }
        public bool IsComplete { get; set; }

        public Device Device { get; set; }
    }
}
