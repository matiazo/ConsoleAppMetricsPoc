using MetricsNetStandard20;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace NetStandard20Lib
{
    public class MetricTrackerConfig
    {
        public IMetric metric { get; set; }
    }
}
