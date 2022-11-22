using NetStandard20Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(".net framework is not compatible with netstandard 2.1, metrics are not available");

            var config = new MetricTrackerConfig();

            var metricTacker = new MetricTracker();
            await metricTacker.InitAsync(config);

            await metricTacker.Track();

            Console.ReadLine();
        }
    }
}
