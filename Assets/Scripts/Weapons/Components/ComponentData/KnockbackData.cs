using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    public class KnockbackData : ComponentData<AttackKnockback>
    {
        protected override void SetComponentDependency()
        {
            ComponentDependency = typeof(Knockback);
        }
    }
}
