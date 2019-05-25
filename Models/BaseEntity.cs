using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteTool.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}