public class LogEntryValidator : AbstractValidator<LogEntry> {
    public LogEntryValidator() {
        RuleFor(x => x.AppName).NotEmpty();
        RuleFor(x => x.Message).NotEmpty();
        RuleFor(x => x.Level).NotEmpty();
    }
}