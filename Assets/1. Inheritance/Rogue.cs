using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Because the Rogue is an Adventurer, we inherit from the Adventurer class.
 * This means we get access by default to all the variables and functions set in Adventurer.
 * When we use the Rogue class on an object in Unity, we'll be able to manipulate their stats in the Inspector.
 * However, we are also going to edit them here so we can set new defaults for this subclass.
 */
public class Rogue : Adventurer
{
    void Awake()
    {
        /*
         * Awake() is activated the moment the script is loaded and before the game truly starts, meaning anything we set in here will be applied first.
         * Since we already set all the default variables in Adventurer, we have access to them and can override them in Awake().
         * However, if we change these values in the Inspector, it's those values that will override everything else - even if we set values here for the Default Rogue.
         * Values set in the class we inherit from (Adventurer) are set first, get overriden by Awake(), but awake is overriden by anything we set in Inspector.
         */

        adventurerName = "Default Rogue";
        movementSpeed = 8;
        health = 80;
        armour = 14;
        weapon = "Daggers";
    }

    /*
     * We also created functions in the Adventurer class that we inherit.
     * Because those functions were set as "virtual", we must now override them with the functionality we desire.
     * However, if the functionality in the Adventurer class is fine as it is, we can just use "base." and call the function to use the default version.
     * Using this, we can do additional code after the basic code takes place that is unique to this class.
     */

    public override void MoveAdventurer()
    {
        base.MoveAdventurer();
    }

    public override void Attack(Adventurer target)
    {
        base.Attack(target);
        Debug.Log(adventurerName + " blinds " + target.adventurerName + " with their attack!");
    }
}
