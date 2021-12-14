using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPA.Logging;

namespace BSIPAConfigRepro
{
    [Plugin(RuntimeOptions.DynamicInit), NoEnableDisable]
    public class Plugin
    {
        [Init]
        public Plugin(Logger logger, Config conf)
        {
            var config = conf.Generated<PluginConfig>();

            logger.Notice($"A normal bool: {config.ANormalBool}");
            logger.Notice($"A nullable bool: {config.ANullableBool}");
        }
    }
}