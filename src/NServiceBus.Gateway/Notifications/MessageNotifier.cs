namespace NServiceBus.Gateway.Notifications
{
    using System;

    class MessageNotifier : IMessageNotifier
    {
        public event EventHandler<MessageReceivedOnChannelArgs> MessageForwarded;

        void IMessageNotifier.RaiseMessageForwarded(string from, string to, TransportMessage message)
        {
            if (MessageForwarded != null)
            {
                MessageForwarded(this, new MessageReceivedOnChannelArgs
                {
                    FromChannel = from,
                    ToChannel = to,
                    Message = message
                });
            }
        }
    }
}