using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLoggerConnector
{
    internal class Program
    {
        private const int LangId = 1031;
        static void Main(string[] args)
        {
            //using(var sink = new PostresSink())
            //{
            //    var connector = new EventLoggerConnector(sink, LangId);

            //    connector.Connect();

            //    Console.WriteLine("Press Enter to exit.");
            //    Console.ReadKey();

            //    connector.Disconnect();
            //}

            var sink = new ConsoleSink();
            var connector = new EventLoggerConnector(sink, LangId);

            connector.Connect();

            Console.WriteLine(connector.IsConnected ? "Connected." : "NOT Connected!");

            Console.WriteLine("Press Enter to exit.");
            Console.ReadKey();

            connector.Disconnect();
        }
    }
}
