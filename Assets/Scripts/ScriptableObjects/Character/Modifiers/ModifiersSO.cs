using Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.SO
{
    public abstract class ModifiersSO : ScriptableObject
    {
        public string ModifierName;
        public abstract void ApplyModifier(CharacterManager character, int value);
    }
}