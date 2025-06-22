public interface ILogProcessor {
    Task ProcessAsync(LogEntry entry, CancellationToken cancellationToken = default);
}