using System;

namespace EventLoggerConnector
{
    public class Message
    {
        public int Id { get; internal set; }
        public Guid EventClass { get; internal set; }
        public int EventId { get; internal set; }
        public string Text { get; internal set; }
        public DateTime TimeRaised { get; internal set; }
        public int SourceId { get; internal set; }
        public string SourceName { get; internal set; }

        public override string ToString()
        {
            return $"Message [Id={Id}, EventClass={EventClass}, EventId={EventId}, Text=\"{Text}\", TimeRaised={TimeRaised:o}, SourceId={SourceId}, SourceName=\"{SourceName}\"]";
        }
    }
}