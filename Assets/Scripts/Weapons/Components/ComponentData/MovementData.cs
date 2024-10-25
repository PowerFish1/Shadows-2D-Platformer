using System.Collections;
using System.Collections.Generic;
using Powerfish.Weapons.Component;
using Powerfish.Weapons.Components;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    public class MovementData : ComponentData<AttackMovement>
    {
        protected override void SetComponentDependency()
        {
            ComponentDependency = typeof(Movement);
        }
    }
}
