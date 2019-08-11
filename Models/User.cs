using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProjectApi.Models
{
    [Table("user")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id"), Required]
        public int Id { get; set; }
        [Column("full_name"), Required]
        public string FullName { get; set; }
        [Column("user_name"), Required]
        public string UserName { get; set; }
        [Column("password"), Required]
        public string Password { get; set; }
        [Column("role"), Required]
        public bool Role { get; set; }
        [Column("status"), Required]
        public bool Status { get; set; }
    }
}