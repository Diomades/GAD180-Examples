using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * In this example of the Weapon, we're going to use a ScriptableObject to contain its information instead of using a MonoBehaviour.
 * A ScriptableObject is just a collection of data. It can have functions, but it is essentially just a nice light weight storage method.
 * Since weapons are just a collection of data without functions, this makes ScriptableObject particularly good for it.
 */

namespace Scripted
{
    public enum DamageType { Blunt, Sharp, Fire, Ice }

    /*
     * One of the cool things we can do in Unity is allow objects to be created inside of the Unity file system.
     * This works especially well for Scriptable Objects.
     * With this line here, when you go to Unity and right click inside a project folder, you will see a menu option for "New Weapon".
     */
    [CreateAssetMenu(fileName = "New Weapon", menuName = "New Weapon")]
    public class WeaponScriptableObject : ScriptableObject
    {
        //Everything else about the weapons information is essentially the same as when it was a MonoBehaviour, only now we don't store it inside the scene - we store it inside the project files.
        public new string name;
        public DamageType type;
        public float minDamage;
        public float maxDamage;
        public float weight;
    }
}