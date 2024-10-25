using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Powerfish.Interfaces;

namespace Powerfish.Weapons.Components
{
    public class PoiseDamage : WeaponComponent<PoiseDamageData, AttackPoiseDamage>
    {
        private ActionHitbox hitbox;

        private void HandleDetectCollider2D(Collider2D[] colliders)
        {
            foreach (var item in colliders)
            {
                if (item.TryGetComponent(out IPoiseDamageable poiseDamageable))
                {
                    poiseDamageable.DamagePoise(currentAttackData.amount);
                }
            }
        }

        protected override void Start()
        {
            base.Start();

            hitbox = GetComponent<ActionHitbox>();

            hitbox.OnDetectedCollider2D += HandleDetectCollider2D;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            hitbox.OnDetectedCollider2D -= HandleDetectCollider2D;
        }
    }
}
