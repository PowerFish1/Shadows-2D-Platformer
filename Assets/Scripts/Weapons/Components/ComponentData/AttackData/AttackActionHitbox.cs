using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Powerfish.Weapons.Components
{
    [Serializable]
    public class AttackActionHitbox : AttackData
    {
        public bool Debug;

        [field: SerializeField] public Rect Hitbox { get; private set; }
    }
}
