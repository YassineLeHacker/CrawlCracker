﻿using UnityEngine;

namespace CrawlCheat
{
    public class Loader
    {
        public static void Init()
        {
            Loader.Load = new UnityEngine.GameObject();
            Loader.Load.AddComponent<Hacks>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }

        public static void Unload()
        {
            _Unload();
        }

        private static void _Unload()
        {
            GameObject.Destroy(Loader.Load);
        }

        private static GameObject Load;
    }
}
