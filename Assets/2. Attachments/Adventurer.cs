using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * For this example, we're using the same Adventurer class from the Inheritance example. See that example for more information.
 * The major change we are making here is that we've constructed a new script to contain information about Weapons.
 * There is a variety of approaches to this problem. WeaponStruct.cs will show you one method, but for this example we'll be using WeaponMonoBehaviour.cs
 * The major difference is that with the WeaponMonoBehaviour, we can make changes much easier in the Inspector by putting our weapon scripts on Game Objects.
 */

//By using a Namespace, we indicate that this type of Adventurer is different from the kind we used in the Inheritance example and can have the same script name.
//To use this version of Adventurer, other scripts will need to put "using Attachment" at the top of the class.
namespace Attachment
{
    public class Adventurer : MonoBehaviour
    {
        public string adventurerName = "Default Adventurer";
        public float movementSpeed = 5;
        public float health = 100;
        public int armour = 10;
        public WeaponMonoBehaviour weapon; 
        //We want to store a copy of the WeaponMonoBehaviour script, as this will contain all of the information that we enter in editor.
        //This way, to give this adventurer a unique weapon, we simply need to drag over the Game Object with the weapon data we want into the Weapon section of the Adventurer class in the inspector.

        public virtual void MoveAdventurer()
        {
            Debug.Log(adventurerName + " moves " + movementSpeed + " spaces");
        }

        public virtual void Attack(Adventurer target)
        {
            if(weapon == null)
            {
                //We have no weapon equipped, so let's tell the player
                Debug.Log(adventurerName + " has no weapon equipped!");
            }
            else
            {
                /*
                 * Because we have a weapon equipped, we now have access to all the values on that weapon we entered into the Inspector.
                 * So let's pull that information to see how much damage we do. We can use the Min and Max damage values to generate some damage on the target.
                 * If our Adventurer had stats, we could potentially change the weapon damage based on those stats as well. In this example we don't, so we'll keep it simple.
                 * For this example, we'll see if our damage is higher than the target's armour to check if we deal damage or not.
                 */
                float damage = Random.Range(weapon.minDamage, weapon.maxDamage);
                if (damage > target.armour)
                {
                    //We did enough damage to penetrate armour, so deal damage minus the armour value
                    target.health -= (damage - target.armour);
                    Debug.Log(adventurerName + " does " + damage + " damage to " + target.adventurerName + " with their " + weapon.name + "!");
                    Debug.Log(target.adventurerName + " has " + target.health + "HP remaining!");
                }
                else
                {
                    //We didn't do enough damage to get through armour, so inform the player.
                    Debug.Log(adventurerName + " could not penetrate " + target.adventurerName + "'s armour with their " + weapon.name + "!");
                }
            }
        }
    }
}
