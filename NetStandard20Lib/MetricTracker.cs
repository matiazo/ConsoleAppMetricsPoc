using MetricsNetStandard20;
using System;
using System.Threading.Tasks;

namespace NetStandard20Lib
{
    public class MetricTracker
    {
        IMetric metric;

        public MetricTracker()
        {
            Console.WriteLine("Ctor of a class in netstandard 2.0 lib");
        }

        public Task InitAsync(MetricTrackerConfig config)
        {
            metric = config.metric;

            return Task.CompletedTask;
        }

        public async Task Track()
        {
            var assemblies = this.GetType().Assembly.GetReferencedAssemblies();

            Console.WriteLine("This is a netstandard 2.0 lib");
            foreach (var assembly in assemblies)
            {
                var version = assembly.Version;

                Console.WriteLine($"   {assembly.FullName} - {version}");
            }

            if (this.metric != null)
                await metric?.TrackMetric("Test", new System.Collections.Generic.Dictionary<string, long>());
            else
                Console.WriteLine("cannot emit Metric, IMetricIs not available");

            Console.WriteLine("ended track matric");
        }
    }
}
