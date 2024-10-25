using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    [Serializable]
    public class AttackKnockback : AttackData
    {
        [field: SerializeField] public Vector2 angle { get; private set; }
        [field: SerializeField] public float strength { get; private set; }
    }
}
