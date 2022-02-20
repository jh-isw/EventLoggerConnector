using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventLoggerConnector
{
    public class Message
    {
        public DateTime TimeRaised { get; internal set; }

        public Guid EventClass { get; internal set; }

        public int EventId { get; internal set; }

        public int SourceId { get; internal set; }
        
        public string Text { get; internal set; }

        public string SourceName { get; internal set; }
    }
}