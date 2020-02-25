using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT IS NOT USED, AND EXISTS PURELY AS AN EXAMPLE OF AN ALTERNATE METHOD OF STORING WEAPON VALUES.

/*
 * Unlike a Class, a Struct exists as a data storage type. It cannot run functions and only contains variables.
 * Using a Struct, we are essentially creating a new type of Variable with a series of other variables expected of it.
 * Think of it like this: weapons have names, damage types, damage values, and weight. But weapons are swung by Adventurers, so the weapon doesn't need to do anything. It just needs to contain information.
 * For our game, we want a few different damage types - and so we store this as an Enum. An Enum is essentially just a custom list of objects. We can use this later to check the type of damage if an enemy is weak or strong against a certain type.
 * You can see the DamageType enum in the weaponMonoBehaviour script.
 */

namespace Attachment
{
    public struct WeaponData
    {
        public string name;
        public DamageType type;
        public float minDamage;
        public float maxDamage;
        public float weight;
    }

    /*
     * We have our weapon data type now, but we have no weapons created. Rather than overcomplicating the creation of new weapons, we can just use a class to create them and store them.
     * In order to access this information any time from any other script, we declare this class as Static. This means it's accessible without needing to create a new copy of it in our other classes.
     * This way, if we ever want to reference a specific weapon type, we can just reference the Weapon class and call the weapon type we want.
     */
    public static class WeaponStruct
    {
        public static WeaponData dagger = new WeaponData { name = "Dagger", type = DamageType.Sharp, minDamage = 3f, maxDamage = 6f, weight = 1.5f };
        public static WeaponData staff = new WeaponData { name = "Staff", type = DamageType.Blunt, minDamage = 1f, maxDamage = 4f, weight = 2.5f };
        public static WeaponData iceHammer = new WeaponData { name = "Ice Hammer", type = DamageType.Ice, minDamage = 6f, maxDamage = 12f, weight = 6f };
    }
}