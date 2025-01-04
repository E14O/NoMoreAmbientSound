using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace NoMoreAmbientSound
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */

            Utilla.Events.GameInitialized += OnGameInitialized;
        }
        void OnGameInitialized(object sender, EventArgs e)
        {
        }

        void Update()
        {
            var Forest = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight");
            Destroy(Forest);

            var Metropilis = GameObject.Find("MetroMain/Metro_SoundObjects");
            Destroy(Metropilis);

            var Mountains = GameObject.Find("Mountain/MountainsAmbience");
            Destroy(Mountains);

            var Basement = GameObject.Find("Basement/DungeonRoomAnchor/DungeonBasement/");
            Destroy(Basement);

            var Arcade = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/Arcade_prefab/ArcadeAudio");
            Destroy(Arcade);

            var Beach = GameObject.Find("Beach/Beach_SoundObjects");
            Destroy(Beach);

            var Clouds = GameObject.Find("skyjungle/Ambience");
            Destroy(Clouds);

            var Caves = GameObject.Find("Cave_Main_Prefab/NewCave/Cave_Audio_Prefab");
            Destroy(Caves);

            // ik i could have just disabled the actual sound hearning thing in he rig but now i can easily choice which sound i want to remove (to hear again)
        }

        // Code Is All Written By E14O, Its Not To Be Skidded From Nor Sold Without His Permmision.
    }
}
