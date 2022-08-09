using HarmonyLib;

namespace SilentProtagonist
{
    internal static class Patches
    {
        [HarmonyPatch(typeof(PlayerVoice), "CanPlayPlayerVoiceEvents")]
        private static class SilenceProtagonist
        {
            internal static bool Prefix(ref bool __result)
            {
                __result = false;
                return false;
            }
        }
    }
}
