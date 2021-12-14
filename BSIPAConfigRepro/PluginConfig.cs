using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace BSIPAConfigRepro
{
    internal class PluginConfig
    {
        public virtual bool ANormalBool { get; set; }
        public virtual bool? ANullableBool { get; set; }
    }
}