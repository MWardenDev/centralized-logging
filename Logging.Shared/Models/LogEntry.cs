public class LogEntry
{
    public string AppName { get; set; } = "";
    public string Message { get; set; } = "";
    public string? Exception { get; set; } = "";
    public string Level { get; set; } = "Information";
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public Dictionary<string, string>? Tags { get; set; } // OTel-like custom fields
}