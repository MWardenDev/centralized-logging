using Logging.Shared.Interfaces;
using Logging.Shared.Models;

namespace Logging.API.Http.Services;

public class ConsoleLogProcessor : ILogProcessor
{
    public Task ProcessAsync(LogEntry entry, CancellationToken cancellationToken = default)
    {
        ConsoleLogProcessor.WriteLine($"[{entry.Timestamp}] {entry.Level}: {entry.Message}");
        return Task.CompletedTask;
    }
}