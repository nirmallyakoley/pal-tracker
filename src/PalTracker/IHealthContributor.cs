using System.Linq;
using Steeltoe.Common.HealthChecks;
using static Steeltoe.Common.HealthChecks.HealthStatus;

namespace PalTracker
{
    public interface  IHealthContributor
    {
        HealthCheckResult Health();
        string Id { get; }
      
    }
}