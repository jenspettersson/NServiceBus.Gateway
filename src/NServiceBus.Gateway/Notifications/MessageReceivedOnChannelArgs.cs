namespace NServiceBus.Gateway.Notifications
{
    using System;
    using System.Collections.Generic;

    class MessageReceivedOnChannelArgs : EventArgs
    {
        public byte[] Body { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string FromChannel { get; set; }
        public string ToChannel { get; set; }
        public bool Recoverable { get; set; }
        public TimeSpan TimeToBeReceived { get; set; }
        public string Id { get; set; }
    }
}