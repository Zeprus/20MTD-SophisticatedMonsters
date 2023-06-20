using BepInEx;
using System.IO;
using System.Reflection;

namespace SophisticatedMonsters
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("AssetReplacer")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            string modFolder = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).Name;
            AssetReplacer.API.Register(modFolder, AssetReplacer.AssetType.Textures);
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
