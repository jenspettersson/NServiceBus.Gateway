namespace NServiceBus.AcceptanceTests.Gateway
{
    using System;
    using System.Threading.Tasks;
    using NServiceBus.Gateway;

    class FakeChannelReceiver : IChannelReceiver
    {
        public void Start(string address, int maxConcurrency, Func<DataReceivedOnChannelArgs, Task> dataReceivedOnChannel)
        {
        }

        public Task Stop()
        {
            return Task.FromResult(0);
        }
    }
}