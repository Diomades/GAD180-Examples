using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * In this example for weapon storage, we use MonoBehaviour so this script can be attached to a Game Object in Unity.
 * This way, we can have all the information we need about the weapon (name, damage type, damage values, and weight) exposed in the editor, and can make different Game Objects in Unity and modify their values in editor to create unique weapons.
 * While this may not be the most efficient way to handle numerous objects, it is a very easy and designer-focused way of handling the problem.
 * For our game, we want a few different damage types - and so we store this as an Enum. An Enum is essentially just a custom list of objects. We can use this later to check the type of damage if an enemy is weak or strong against a certain type.
 */

public enum DamageType { Blunt, Sharp, Fire, Ice }

public class WeaponMonoBehaviour : MonoBehaviour
{
    public new string name; //Because Game Objects have names, we use the "new" keyword to indicate we want a new string called name specific to this class.
    public DamageType type;
    public float minDamage;
    public float maxDamage;
    public float weight;
}

/*
 * This is really all we need for this script. Using a class instead of a struct is likely overkill, as we never use any functions - but it does mean we could put some functionality on our weapons later if we desire.
 */
