using HarmonyLib;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnityEngine;

namespace ExtraRoles
{
    [HarmonyPatch(typeof(PlayerPhysics), nameof(PlayerPhysics.WalkPlayerTo))]
    class WalkPatch
    {
        public static bool Prefix(Vector2 ALCLHFLGKPK, float HJBNKNJJNGB)
        {
            var vec = ALCLHFLGKPK;
            var n = HJBNKNJJNGB;
            System.Console.WriteLine("WalkPlayerTo x = " + vec.x + " y = " + vec.y + " n = " + n);
            return true;
        }
        
        public static void Postfix(ref IEnumerator __result)
        {
            System.Console.WriteLine("WalkPlayerTo res = " + __result);
            // __result = Vector2.one;
        }
    }
    
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.FixedUpdate))]
    public static class ExamplePatch
    {
        public static void Postfix(PlayerControl __instance)
        {
            // var vec = __instance.GetTruePosition();
            // LineRenderer.Set
            // var bla = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerControl>.NativeClassPtr, 100682276);
            // System.Console.WriteLine("bla: " + bla);
            // System.Console.WriteLine("TruePosition of " + __instance.name + " x = " + vec.x + " y = " + vec.y);
        }
    }
    
    // [HarmonyPatch(typeof(ShipStatus), nameof(ShipStatus.CalculateLightRadius))]
    // public static class LightRadiusPatch
    // {
    //     public static bool Prefix(GameData.PlayerInfo __instance)
    //     {
    //         return true;
    //     }
    //     
    //     public static void Postfix(ref float __result)
    //     {
    //         __result = 0.1f;
    //     }
    // }
}