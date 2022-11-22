using MetricsNetStandard20;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MetrixNetStandard21
{
    public class Metric : IMetric
    {
        public Task TrackMetric(string name, Dictionary<string, long> metrics)
        {
            var assemblies = this.GetType().Assembly.GetReferencedAssemblies();

            Console.WriteLine();
            foreach (var assembly in assemblies)
            {
                var version = assembly.Version;

                Console.WriteLine($"   {assembly.FullName} - {version}");
            }
            Console.WriteLine();

            return Task.CompletedTask;
        }
    }
}
