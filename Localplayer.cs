using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TheForest
{
    class Localplayer : MonoBehaviour
    {
        private TheForest.Utils.LocalPlayer localPlayer;
        public void Get()
        {
            this.localPlayer = GameObject.FindObjectOfType<TheForest.Utils.LocalPlayer>();
        }

        public void God(bool enabled)
        {
            if(enabled)
            {
                this.localPlayer._stats.Health = 1000;
            }
        }
        public void WaterBreathing(bool enabled)
        {
            if (enabled)
            {
                this.localPlayer._stats.AirBreathing.CurrentLungAir = 1000;
            }
        }
        public void MaxStamina(bool enabled)
        {
            if (enabled)
            {
                this.localPlayer._stats.Stamina = 1000;
            }
        }
        public void DisableBlood(bool enabled)
        {
            if (enabled)
            {
                this.localPlayer._stats.IsBloody = false;
            }
        }

    }
}
