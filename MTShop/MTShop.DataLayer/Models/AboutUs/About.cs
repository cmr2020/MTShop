using System.ComponentModel.DataAnnotations;

namespace MTShop.DataLayer.Models.AboutUs
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Image { get; set; }

    }
}
