namespace RequestLoggingApp.Models;

public class RequestLog
{
    public int Id { get; set; }
    public string? Body { get; set; } // Nullable string
    public string? Path { get; set; } // Nullable string
    public string? Method { get; set; } // Nullable string
    public DateTime Timestamp { get; set; }
}