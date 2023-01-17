using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Configuration.Entity
{

    [Table("menu_config")]
    public class MenuConfig
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("image_name", TypeName = "varchar(200)")]
        public string? ImageName { get; set; }
        [Column("name", TypeName = "varchar(200)")]
        public string? Name { get; set; }
        [Column("target_ctl_name", TypeName = "varchar(200)")]
        public string? TargetCtlName { get; set; }
        [Column("queries_text",TypeName = "varchar(200)")]
        public string? QueriesText { get; set; }
        [Column("is_visible",TypeName = "int")]
        public bool? IsVisible { get; set; }
        [Column("update_time",TypeName = "TEXT")]
        public DateTime? UpdateTime { get; set; }
        [Column("create_name",TypeName = "TEXT")]
        public DateTime? CreateTime { get; set; }
    }
}
