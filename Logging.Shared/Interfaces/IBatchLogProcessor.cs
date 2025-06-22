public interface IBatchLogProcessor {
    Task ProcessBatchAsync(IEnumerable<LogEntry> entries, CancellationToken cancellationToken = default);
}