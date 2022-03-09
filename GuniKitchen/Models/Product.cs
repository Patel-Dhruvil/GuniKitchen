using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniKitchen.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(200, ErrorMessage = "{0} cannot be more than {1} characters.")]
        public string ProductName { get; set; }

        [Display(Name = "Category")]
        [ForeignKey(nameof(Product.Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(100, ErrorMessage = "{0} cannot be more than {1} characters.")]
        public string ProductDescription { get; set; }


        [Display(Name = "Price")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        public int ProductPrice { get; set; }

        [Display(Name = "Size")]
        public string ProductSize { get; set; }
    }
}
