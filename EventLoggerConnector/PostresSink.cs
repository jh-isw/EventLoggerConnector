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

            int ret = 0;
            try
            {
                ret = (int)(_context?.SaveChanges());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.InnerException.Message);
                }
            }
            Console.WriteLine($"{ret} entries written.");
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}