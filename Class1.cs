using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// credits to proton for the awesome tut

namespace TheForest
{
   public class Loader
    {
        public static readonly GameObject gameObject = new GameObject();

        public static void Load()
        {
            gameObject.AddComponent<HackMain>();

            UnityEngine.Object.DontDestroyOnLoad(gameObject);
        }

        public static void Unload()
        {
            GameObject.Destroy(gameObject);
        }
    }
}
