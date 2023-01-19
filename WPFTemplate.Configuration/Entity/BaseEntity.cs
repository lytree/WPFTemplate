using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Configuration.Entity
{
    public abstract class BaseEntity
    {
        [Column("update_time",TypeName = "TEXT")]
        public DateTime? UpdateTime { get; set; }
        [Column("create_time",TypeName = "TEXT")]
        public DateTime? CreateTime { get; set; }
    }
}
