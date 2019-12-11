using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using System.Reflection;
using Base.Utils.GameConsole;

namespace ConsoleEnabler
{
    public class ConsoleEnable
    {
        public static void Init()
        {
            var harmony = HarmonyInstance.Create("io.github.realitymachina.consoleenabler");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

        }

        [HarmonyPatch(typeof(GameConsoleWindow), "Awake")]
        public static class PhoenixPoint_GameConsoeWindow_AWake_Patch
        {
            static void Postfix(GameConsoleWindow __instance)
            {
                 GameConsoleWindow.DisableConsoleAccess = false;
                
            }
        }
    }
}
