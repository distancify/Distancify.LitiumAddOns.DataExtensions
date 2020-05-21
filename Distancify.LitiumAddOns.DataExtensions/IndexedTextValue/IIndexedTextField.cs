using Litium.Runtime.DependencyInjection;

namespace Distancify.LitiumAddOns.DataExtensions
{
    [Service(Lifetime = DependencyLifetime.Singleton, ServiceType = typeof(IIndexedTextField))]
    public interface IIndexedTextField
    {
        string FieldDefinitionId { get; }
    }
}
