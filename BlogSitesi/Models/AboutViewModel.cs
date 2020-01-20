using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BlogSitesi.Models
{
    public class AboutViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Hakkımda bilgisini göstermek için bu alan zorunludur.")]
        [MinLength(4, ErrorMessage = "{0} için en az {1} karakter giriniz !")]
        [MaxLength(20,ErrorMessage = "{0} en fazla {1} karakter uzunluğunda veri girişi yapabilirsiniz !")]
        public string TitleName { get; set; }

        
        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Hakkımda bilgisinin içeriği burada değiştirilmelidir.")]
        [AllowHtml] //requestlere kod yazmasına bile izin verir.

        public string AboutDescription { get; set; }


    }
}