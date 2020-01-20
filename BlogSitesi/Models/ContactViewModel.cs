using System.ComponentModel.DataAnnotations;

namespace BlogSitesi.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "İletişim bilgisini göstermek için bu alan zorunludur.")]
        [MinLength(4,ErrorMessage = "{0} için en az {1} karakter giriniz !")]
        [MaxLength(50,ErrorMessage = "{0} için en fazla {1} karakter uzunluğunda veri girişi yapabilirsiniz !")]
        public string FullName { get; set; }
        
        [Display(Name = "İletişim Numarası")]
        [Required(ErrorMessage = "İletişim numarasını göstermek için bu alan zorunludur.")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "Mail adresi")]
        [Required(ErrorMessage = "Mail adresinin bilgisi için bu alan zorunludur")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Geçersiz E Mail adresi")]
        public string EmailAddress { get; set; }

    }
}