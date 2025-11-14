using System.Net.Http.Json;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services;

public class MembershipService
{
    private readonly HttpClient _httpClient;
    private List<Membership>? _memberships;

    public MembershipService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Membership>> GetMembershipsAsync()
    {
        if (_memberships == null)
        {
            _memberships = await _httpClient.GetFromJsonAsync<List<Membership>>("memberships.json") 
                ?? new List<Membership>();
        }
        return _memberships;
    }

    public async Task<Membership?> GetMembershipByIdAsync(string id)
    {
        var memberships = await GetMembershipsAsync();
        return memberships.FirstOrDefault(m => m.Id == id);
    }

    public string GenerateMembershipCode()
    {
        var random = new Random();
        var number = random.Next(100, 999);
        return $"GYM-{DateTime.Now.Year}-{number}";
    }
}


