using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Configuration.Entity
{
    [Table("option_group")]
    public class OptionGroup: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("group_key",TypeName="varchar(200)")]
        public string GroupKey { get; set; }
        [Column("group_name",TypeName="varchar(200)")]
        public string? GroupName { get; set; }
        [Column("group_desc",TypeName="varchar(200)")]
        public string? GroupDesc { get; set; }
        [Column("group_type",TypeName="int")]
        public int? GroupType { get; set; }
    }
}
