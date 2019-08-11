using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProjectApi.Models
{
    [Table("product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("product_id"), Required]
        public int Id { get; set; }

        [Column("description"), Required,MaxLength(300)]
        public string Description { get; set; }

        [Column("cost", TypeName = "decimal(13, 4)"), Required]
        public decimal Cost { get; set; }

        [Column("price", TypeName = "decimal(13, 4)"), Required]
        public decimal Price { get; set; }

        [Column("status"), Required]
        public bool Status { get; set; }
    }
}