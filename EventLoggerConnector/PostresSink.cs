using System;

namespace EventLoggerConnector
{
    internal class PostresSink : IEventSink, IDisposable
    {
        private readonly EventsDbContext _context;
        public PostresSink()
        {
            _context = new EventsDbContext();
        }

        public void OnMessage(Message msg)
        {
            _context?.Messages.Add(msg);
            var ret = _context?.SaveChanges();
            Console.WriteLine($"{ret} entries written.");
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}