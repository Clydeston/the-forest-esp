using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TheForest
{

    public partial class HackMain : MonoBehaviour
    {
        mutantController controller;
        TheForest.Utils.LocalPlayer player;
        Camera Camera;
        
        public void Start()
        {
            player = GameObject.FindObjectOfType<TheForest.Utils.LocalPlayer>();
            //entityList = GameObject.FindObjectsOfType<mutantAI>();
            controller = GameObject.FindObjectOfType<mutantController>();
        }

        public void Update()
        {
            Camera = Camera.main;

            if (player)
            {
                player.UnlimitedItems(true);
                player._stats.Health = 1000;
                player._stats.Stamina = 1000;
                player._stats.AirBreathing.CurrentLungAir = 1000;
                player._stats.AirBreathing.RebreatherIsEquipped = true;
                player._stats.AirBreathing.RebreatherIsEquipped = true;
            }

        }

        public void DrawBox(Transform enemy, string text)
        {
            Vector3 w2sPos = Camera.WorldToScreenPoint(enemy.position);
            float distanceFromPlayer = Vector3.Distance(Camera.transform.position, enemy.position);
            if (w2sPos.z > 0)
            {
                float x = w2sPos.x;
                float y = Screen.height - w2sPos.y;
                float height = Screen.height - w2sPos.y + GUI.skin.label.fontSize * 2;
                float width = w2sPos.x + (text.Length * GUI.skin.label.fontSize);

                GUI.Label(new Rect(x, y, height, width), text);
            }
        }

        public void OnGUI()
        {
            GUI.Label(new Rect(100, 100, 300, 100), "Loaded");
            if (controller)
            {
                if (controller.ActiveCannibals != null && Camera)
                {
                    if (controller.ActiveCannibals.Count() != 0)
                    {
                        foreach (var enemy in controller.ActiveCannibals)
                        {
                            DrawBox(enemy.transform, enemy.name);
                        }
                    }
                }
            }
        }

    }
}
