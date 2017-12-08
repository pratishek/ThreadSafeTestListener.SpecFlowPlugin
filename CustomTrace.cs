namespace TraceDisablePlugin.SpecFlowPlugin
{
    using TechTalk.SpecFlow.Plugins;
    using TechTalk.SpecFlow.Tracing;
    public class CustomTrace : IRuntimePlugin
    {
        public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
        {
            runtimePluginEvents.CustomizeGlobalDependencies += RuntimePluginEvents_CustomizeGlobalDependencies;
        }

        private void RuntimePluginEvents_CustomizeGlobalDependencies(object sender, CustomizeGlobalDependenciesEventArgs e)
        {
            e.ObjectContainer.RegisterTypeAs<ThreadSafeSpecFlowTestListener, ITraceListener>();
        }

    }
}
