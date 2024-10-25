using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    [Serializable]
    public class AttackPoiseDamage : AttackData
    {
        [field: SerializeField] public float amount { get; private set; }
    }
}
