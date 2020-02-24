using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Because the Mage is an Adventurer, we inherit from the Adventurer class.
 * This means we get access by default to all the variables and functions set in Adventurer.
 * When we use the Mage class on an object in Unity, we'll be able to manipulate their stats in the Inspector.
 * However, we are also going to edit them here so we can set new defaults for this subclass.
 */
public class Mage : Adventurer
{
    void Awake()
    {
        /*
         * Awake() is activated the moment the script is loaded and before the game truly starts, meaning anything we set in here will be applied first.
         * Since we already set all the default variables in Adventurer, we have access to them and can override them in Awake().
         * However, if we change these values in the Inspector, it's those values that will override everything else - even if we set values here for the Default Rogue.
         * Values set in the class we inherit from (Adventurer) are set first, get overriden by Awake(), but awake is overriden by anything we set in Inspector.
         */

        adventurerName = "Default Mage";
        movementSpeed = 4;
        health = 60;
        armour = 12;
        weapon = "Staff";
    }

    /*
     * We also created functions in the Adventurer class that we inherit.
     * Because those functions were set as "virtual", we must now override them with the functionality we desire
     */

    public override void MoveAdventurer()
    {
        base.MoveAdventurer();
    }

    public override void Attack(Adventurer target)
    {
        /*
         * For the Mage subclass, we want to do an entirely different kind of attack whenever they attack to represent their magical attack.
         * However, it is still an attack - we just want it to be unique when we call this class.
         * As such, we can override the Attack function and just write in new functionality instead of using the Base function at all.
         */

        Debug.Log(adventurerName + " shoots a magic missle at " + target.adventurerName + " using their " + weapon + "!");
    }
}
