using BattleTech.UI;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_FasterTurn.Patches
{
    [HarmonyPatch(typeof(TurnEventNotification), "WaitForDismissWithTimeoutCoroutine")]
    internal class TurnEventNotification_WaitAndDismissCoroutine_Patch
    {
        public static void Prefix(ref float seconds)
        {
            //Only the turn banner uses 1.5 seconds.
            if (seconds == 1.5f)
            {
                seconds = Core.ModSettings.StartTurnDelaySeconds;
            }

        }
    }
}
