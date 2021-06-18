using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LordAshes
{
    [@BepInPlugin(Guid, "Test2", Version)]
    [BepInDependency(RadialPluginEx.Guid)]
    public class Test2 : BaseUnityPlugin
    {
        // Plugin info
        public const string Guid = "org.lordashes.plugins.Test2";
        public const string Version = "1.0.0.0";

        void Awake()
        {
            RadialPluginEx.EnsureMainMenuItem(RadialPluginEx.Guid + ".Info", RadialPluginEx.MenuType.character, "Info", RadialPluginEx.GetIconFromFile(RadialPluginEx.dir + "Images/Icons/CharacterSheet.png"));
            RadialPluginEx.CreateSubMenuItem(RadialPluginEx.Guid + ".Info", "States", RadialPluginEx.GetIconFromFile(RadialPluginEx.dir + "Images/Icons/Dice.png"), Callback);
        }

        private void Callback(CreatureGuid arg1, string arg2, MapMenuItem arg3)
        {
            SystemMessage.DisplayInfoText("Test2 Selected\r\n" + arg1.ToString());
        }

        void Update()
        {
        }
    }
}
