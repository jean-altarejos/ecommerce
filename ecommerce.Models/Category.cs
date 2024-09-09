using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        [Range(1, 50)]
        public int DisplayOrder { get; set; }


    }
}
