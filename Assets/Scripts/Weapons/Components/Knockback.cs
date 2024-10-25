using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    public class Knockback : WeaponComponent<KnockbackData, AttackKnockback>
    {
        private ActionHitbox hitbox;

        private CoreSystem.Movement movement;

        private void HandleDetectCollider2D(Collider2D[] colliders)
        {
            foreach (var item in colliders)
            {
                if (item.TryGetComponent(out IKnockbackable knockbackable))
                {
                    knockbackable.Knockback(currentAttackData.angle, currentAttackData.strength, movement.FacingDirection);
                }
            }
        }

        protected override void Start()
        {
            base.Start();

            hitbox = GetComponent<ActionHitbox>();

            hitbox.OnDetectedCollider2D += HandleDetectCollider2D;

            movement = Core.GetCoreComponent<CoreSystem.Movement>();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            hitbox.OnDetectedCollider2D -= HandleDetectCollider2D;
        }
    }
}
