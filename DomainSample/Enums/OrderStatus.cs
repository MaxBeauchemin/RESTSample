using System.ComponentModel;

namespace DomainSample.Enums
{
    public enum OrderStatus
    {
        [Description("Processing")]
        Processing,
        [Description("Completed")]
        Completed
    }
}
