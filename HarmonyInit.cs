using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BT_FasterTurn
{
    public class HarmonyInit
    {
        public static void Init(string directory, string settingsJSON)
        {
            try
            {
                ModSettings modSettings = Newtonsoft.Json.JsonConvert.DeserializeObject<ModSettings>(settingsJSON);
                Core.ModSettings = modSettings;
            }
            catch (Exception)
            {
                Core.ModSettings = new ModSettings();
                
            }

            var harmony = HarmonyInstance.Create("io.github.nbk_redspy.BT_FasterTurn");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
