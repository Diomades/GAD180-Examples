using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Nothing has changed about our Weapon script other than putting it in the Clarity namespace so it can be referenced by our new version of Adventurer.
 * Obviously, try to avoid having slightly different versions of the same scripts across different namespaces. This is just for the purposes of providing this example!
 */

namespace Clarity
{
    public enum DamageType { Blunt, Sharp, Fire, Ice }

    public class WeaponMonoBehaviour : MonoBehaviour
    {
        public new string name;
        public DamageType type;
        public float minDamage;
        public float maxDamage;
        public float weight;
    }
}