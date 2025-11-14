using Microsoft.JSInterop;
using System.Text.Json;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services;

public class LocalStorageService
{
    private readonly IJSRuntime _jsRuntime;
    private const string MembershipKey = "userMembership";

    public LocalStorageService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task SaveMembershipAsync(UserMembership membership)
    {
        var json = JsonSerializer.Serialize(membership);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", MembershipKey, json);
    }

    public async Task<UserMembership?> GetMembershipAsync()
    {
        try
        {
            var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", MembershipKey);
            if (string.IsNullOrEmpty(json))
                return null;

            return JsonSerializer.Deserialize<UserMembership>(json);
        }
        catch
        {
            return null;
        }
    }

    public async Task ClearMembershipAsync()
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", MembershipKey);
    }
}


