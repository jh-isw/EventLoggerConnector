using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcEventLoggerAdsProxyLib;

namespace EventLoggerConnector
{
    internal class EventLoggerConnector
    {
        private IEventSink _sink;
        private int _langId;
        private TcEventLogger _logger;

        public EventLoggerConnector(IEventSink sink, int langId = 1033)
        {
            _sink = sink;
            _langId = langId;

            _logger = new TcEventLogger();
            _logger.MessageSent += OnMessageSent;
            //logger.AlarmRaised += OnAlarmRaised;
            //logger.AlarmCleared += OnAlarmCleared;
            //logger.AlarmConfirmed += OnAlarmConfirmed;
        }

        private void OnMessageSent(TcMessage evtObj)
        {
            var msg = new Message()
            {
                EventClass = evtObj.EventClass,
                EventId = unchecked( (int) evtObj.EventId),
                Text = evtObj.GetText(_langId),
                TimeRaised = evtObj.TimeRaised,
                SourceId = unchecked( (int) evtObj.SourceId),
                SourceName = evtObj.SourceName
            };
            _sink.OnMessage(msg);
        }

        public void Connect() => _logger.Connect();

        public void Disconnect() => _logger.Disconnect();
    }
}
