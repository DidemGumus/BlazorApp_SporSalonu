using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models
{
    public class PaymentInfo
    {
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Tutar boş olamaz.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Kart numarası zorunludur.")]
        [CreditCard(ErrorMessage = "Geçerli bir kart numarası girin.")]
        public string CardNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kart sahibinin adı zorunludur.")]
        public string CardHolder { get; set; } = string.Empty;

        [Required(ErrorMessage = "Son kullanma tarihi zorunludur.")]
        [RegularExpression(@"\d{2}/\d{2}", ErrorMessage = "MM/YY formatında olmalıdır.")]
        public string Expiration { get; set; } = string.Empty;

        [Required(ErrorMessage = "Güvenlik kodu zorunludur.")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "3 veya 4 haneli olmalıdır.")]
        public string SecurityCode { get; set; } = string.Empty;
    }
}
