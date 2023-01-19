using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Configuration.Entity
{
    [Table("option_config")]
    public class OptionConfig: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /**
         * 配置名称
         */
        [Column("option_name")]
        public string? OptionName { get; set; }
        /**
         * 选项组件名
         */
        [Column("option_group")]
        public string? OptionGroup { get; set; }
        /**
         * 配置key
         */
        [Column("option_key")]
        public string? OptionKey { get; set; }

        /**
         * 配置值
         */
        [Column("option_value")]
        public string? OptionValue { get; set; }
        /**
         * 选项排序
         */
        [Column("option_priority")]
        public int? OptionPriority { get; set; }

        [Column("option_status")]
        public int? OptionStatus { get; set; }
        /**
         * 设置描述
         */
        [Column("option_desc")]
        public string? OptionDesc { get; set; }

    }
}
