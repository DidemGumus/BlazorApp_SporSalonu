namespace MyBlazorApp.Models;

public class UserMembership
{
    // Kullanıcının seçtiği plan ID'si
    public string MembershipId { get; set; } = "";

    // Üyelik için otomatik üretilen kod (GYM-2025-XXX)
    public string MembershipCode { get; set; } = "";

    // Planın adı (Aylık Üyelik, 6 Aylık Üyelik, Premium vb.)
    public string MembershipName { get; set; } = "";

    // Plan fiyatı
    public decimal Price { get; set; }

    // Plan süresi (gün cinsinden)
    public int DurationDays { get; set; }

    // Üyelik başlangıç ve bitiş tarihleri
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Üyelik aktif mi değil mi?
    public bool IsActive { get; set; } = true;

    // Kullanıcı bilgileri
    public Member Member { get; set; } = new();

    // TAM plan objesine erişim (Dashboard'ta çok önemli)
    public Membership? Membership { get; set; }
}
