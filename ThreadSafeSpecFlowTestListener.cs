namespace TraceDisablePlugin.SpecFlowPlugin
{
    using TechTalk.SpecFlow.Tracing;
    public class ThreadSafeSpecFlowTestListener : IThreadSafeTraceListener
    {
        private readonly ITraceListener _listener;
        public ThreadSafeSpecFlowTestListener()
        {
            _listener = new DefaultListener();
        }

        public void WriteTestOutput(string message)
        {
            if (_listener != null)
                _listener.WriteTestOutput(message);
        }

        public void WriteToolOutput(string message)
        {
            if (_listener != null)
                _listener.WriteToolOutput(message);
        }

    }
}