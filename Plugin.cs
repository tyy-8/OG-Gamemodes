using System;
using BepInEx;
using UnityEngine;
using Utilla.Attributes;
using Utilla.Models;

namespace OGGamemodes
{
    [ModdedGamemode("battle_Paintbrawl", "BATTLE",BaseGamemode.Paintbrawl)]
    [ModdedGamemode("hunt_Hunt", "HUNT",BaseGamemode.Hunt)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // witewwy nothing
    }
}