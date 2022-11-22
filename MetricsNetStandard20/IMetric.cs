using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MetricsNetStandard20
{
    public interface IMetric
    {
        Task TrackMetric(string name, Dictionary<string, long> metrics);
    }
}
