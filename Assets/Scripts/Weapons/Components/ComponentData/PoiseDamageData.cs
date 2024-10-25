using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    public class PoiseDamageData : ComponentData<AttackPoiseDamage>
    {
        protected override void SetComponentDependency()
        {
            ComponentDependency = typeof(PoiseDamage);
        }
    }
}
