namespace RequestLoggingApp.Models;

public class RequestLog
{
    public int Id { get; set; }
    public string? Body { get; set; } 
    public string? Path { get; set; } 
    public string? Method { get; set; } 
    public DateTime Timestamp { get; set; }
}