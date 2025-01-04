using System;
using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NoMoreAmbientSound
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        }

        void OnGameInitialized()
        {
            // since we are in stump when we load and forest is loaded in, we should just destroy it when we spawn
            var Forest = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight");
            if (Forest)
                Destroy(Forest);

            SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        }

        private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
            var Forest = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight");
            if (Forest)
                Destroy(Forest);

            var Metropilis = GameObject.Find("MetroMain/Metro_SoundObjects");
            if (Metropilis)
                Destroy(Metropilis);

            var Mountains = GameObject.Find("Mountain/MountainsAmbience");
            if (Mountains)
                Destroy(Mountains);

            var Basement = GameObject.Find("Basement/DungeonRoomAnchor/DungeonBasement/");
            if (Basement)
                Destroy(Basement);

            var Arcade = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/Arcade_prefab/ArcadeAudio");
            if (Arcade)
                Destroy(Arcade);

            var Beach = GameObject.Find("Beach/Beach_SoundObjects");
            if (Beach)
                Destroy(Beach);

            var Clouds = GameObject.Find("skyjungle/Ambience");
            if (Clouds)
                Destroy(Clouds);

            var Caves = GameObject.Find("Cave_Main_Prefab/NewCave/Cave_Audio_Prefab");
            if (Caves)
                Destroy(Caves);
        }

        // Code Is All Written By E14O, Its Not To Be Skidded From Nor Sold Without His Permission.
    }
}
