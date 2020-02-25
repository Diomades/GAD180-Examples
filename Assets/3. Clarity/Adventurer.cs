using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * In this example, we're further modifying the Adventurer class.
 * As part of our work on the Weapon system, we added in lines in this class that did damage.
 * However, the risk here is that because our variables are public, they can be read from and written to from elsewhere - which leaves our code prone to bugs.
 * A good way to control this is to force ourselves to do only very specific things in our code. So we're going to add some functions to achieve this.
 */
namespace Clarity
{
    public class Adventurer : MonoBehaviour
    {
        /*
         * In future, we could change all of these variables to be private or protected instead of public.
         * Private variables are only available to this class.
         * Protected variables are available to this class and any children of this class.
         * Public variables are available to any class trying to access them - which poses a potential risk if we aren't careful how we write our code.
         */
        public string adventurerName = "Default Adventurer";
        public float movementSpeed = 5;
        public float health = 100;
        public int armour = 10;
        public WeaponMonoBehaviour weapon;

        public virtual void MoveAdventurer()
        {
            Debug.Log(adventurerName + " moves " + movementSpeed + " spaces");
        }

        public virtual void Attack(Adventurer target)
        {
            if (weapon == null)
            {
                //We have no weapon equipped, so let's tell the player
                Debug.Log(adventurerName + " has no weapon equipped!");
            }
            else
            {
                //Rather than having a big chunk of code here, we can instead run a different function - which is much cleaner to look at and easier to fix.
                DealDamage(target);
            }
        }

        public virtual void DealDamage(Adventurer target)
        {
            float damage = Random.Range(weapon.minDamage, weapon.maxDamage);

            if (damage > target.armour)
            {
                Debug.Log(adventurerName + " does " + target.TakeDamage(damage) + " damage to " + target.adventurerName + " with their " + weapon.name + "!");
                Debug.Log(target.adventurerName + " has " + target.health + "HP remaining!");
            }
            else
            {
                //We didn't do enough damage to get through armour, so inform the player.
                Debug.Log(adventurerName + " could not penetrate " + target.adventurerName + "'s armour with their " + weapon.name + "!");
            }
        }

        /*
         * Whenever we take damage, we want to be able to tell the class dealing damage to us just how much damage it dealt.
         * To do this, we can make the function return a float rather than a void. Functions that state 'void' return nothing and just run a script.
         * In this case, it returns the total damage taken after armour.
         */
        public virtual float TakeDamage(float damage)
        {
            float damageTaken = damage - armour;
            health -= damageTaken;
            return damageTaken;
        }

        /*
         * From here on, these are our Getters and Setters.
         * If we had changed our variables to private, we could use the Getters and Setters to return or read the values of those variables.
         * In this case, these are only included here to let you see how they might work.
         */
        public int Armour
        {
            get { return armour; }
        }
        public float Health
        {
            get { return health; }
        }
        public string AdventurerName
        {
            get { return adventurerName; }
            set { adventurerName = value; } //This allows us to rename our adventurer from another script.
        }
    }
}
