using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This first line means the Adventurer class inherits from MonoBehaviour.
 * We want to keep this, as MonoBehavious allows us to attach scripts to Game Objects in Unity.
 * We could delete the ": MonoBehaviour" part here if we didn't care about attaching to Game Objects.
 */
public class Adventurer : MonoBehaviour
{
    /*
     * Inside of Adventurer, we want to define a couple of variables.
     * These variables are things that every adventurer has for our game: a name, movement speed, health, armour, and a weapon.
     * If we set these variables to have defaults here, any class that inherits from Adventurer will have access to these variables and these default values.
     */

    public string adventurerName = "Default Adventurer";
    public float movementSpeed = 5;
    public float health = 100;
    public int armour = 10;
    public string weapon = "Fists";

    /*
     * We can also add functions to our script that children classes should have access to.
     * To do this, we add the "virtual" status to our functions.
     * This indicates to any class that inherits from Adventurer that they should also have Move and Attack functions.
     */

    public virtual void MoveAdventurer()
    {
        Debug.Log(adventurerName + " moves " + movementSpeed + " spaces");
    }

    public virtual void Attack(Adventurer target)
    {
        /*
         * Because all Adventurer's share the same parent class, we know what variables they have in common.
         * As such, the Rogue and Warrior subclasses will still be read as Adventurer.
         * This means that as we can feed a function the class (as we've done in this function) and access all that information.
         * Any functions or variables unique to that class, however, would be inaccessible unless we referenced that class directly.
         */

        Debug.Log(adventurerName + " attacks " + target.adventurerName + " with their " + weapon + "!");
    }
}
