using BepInEx;

namespace LordAshes
{
    [BepInPlugin(Guid, "Test1", Version)]
    [BepInDependency(LordAshes.RadialPluginEx.Guid)]
    public class Test1 : BaseUnityPlugin
    {
        // Plugin info
        public const string Guid = "org.lordashes.plugins.Test1";
        public const string Version = "1.0.0.0";

        void Awake()
        {
            // Ensure that the main menu entry exists
            RadialPluginEx.EnsureMainMenuItem(  RadialPluginEx.Guid + ".Info",          // Use the RadialPlugin Guid as the base with a "Info" suffix for a "Info" menu item
                                                RadialPluginEx.MenuType.character,      // Character type menu
                                                "Info",                                 // Main menu entry is called "Info"
                                                RadialPluginEx.GetIconFromFile(RadialPluginEx.dir + "Images/Icons/CharacterSheet.png") // Icon
                                             );

            // Add an entry into the main menu "Info" sub-menu
            RadialPluginEx.CreateSubMenuItem(   RadialPluginEx.Guid + ".Info",          // Add sub-menu item for the main menu entry dicated by indicated Guid 
                                                "Icons",                                // Sub-menu item text is "Icons"
                                                RadialPluginEx.GetIconFromFile(RadialPluginEx.dir + "Images/Icons/CharacterView.png"), // Icon
                                                Callback                                // Callback which is triggered when sub-menu item is selected
                                            );
        }

        /// <summary>
        /// Callback triggered when the sub-menu item is selected
        /// </summary>
        /// <param name="arg1">CreatureGuid asociated with the mini on which the Radial menu was opened</param>
        /// <param name="arg2">Guid of the main menu</param>
        /// <param name="arg3">MapMenuItem associted with the menu</param>
        private void Callback(CreatureGuid arg1, string arg2, MapMenuItem arg3)
        {
            SystemMessage.DisplayInfoText("Test1 Selected\r\n" + arg1.ToString());
        }

        void Update()
        {
        }
    }
}
