namespace MemoryVault.Shared.Models;

public class VaultItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string ItemType { get; set; } = "Journal"; // Journal, Password
}
