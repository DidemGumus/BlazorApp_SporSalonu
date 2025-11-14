using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models;

public class Member
{
    [Required(ErrorMessage = "Ad Soyad zorunludur")]
    public string FullName { get; set; } = "";

    [Required(ErrorMessage = "E-posta zorunludur")]
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Telefon zorunludur")]
    [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz")]
    public string Phone { get; set; } = "";

    [Required(ErrorMessage = "TC Kimlik No zorunludur")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik No 11 haneli olmalıdır")]
    public string TcKimlikNo { get; set; } = "";
    public string AvatarUrl { get; set; } = "img/default-avatar.png";
}


