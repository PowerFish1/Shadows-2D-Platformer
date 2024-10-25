using System.Collections;
using System.Collections.Generic;
using Powerfish.Interfaces;
using UnityEngine;

namespace Powerfish.CoreSystem
{
    public class PoiseDamageReceiver : CoreComponent, IPoiseDamageable
    {
        private Stats stats;

        public void DamagePoise(float amount)
        {
            stats.Poise.Decrease(amount);
        }

        protected override void Awake()
        {
            base.Awake();

            stats = core.GetCoreComponent<Stats>();
        }
    }
}
