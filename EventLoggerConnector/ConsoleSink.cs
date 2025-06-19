using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoggerConnector
{
    class ConsoleSink : IEventSink
    {
        public void OnMessage(Message msg)
        {
            Console.WriteLine(msg.ToString());
        }
    }
}
