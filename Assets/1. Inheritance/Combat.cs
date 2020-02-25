using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    /*
     * The combat class takes two Adventurers and pits them against one another.
     * This shows us how we can use inheritance to simplify the code we create, as now our scripts are far more reusable.
     * If you drag either the Adventurer, Rogue or Mage classes into this script in the Inspector, you will get entirely different results in the debugger when you start the game.
     */

    public Adventurer attacker;
    public Adventurer defender;

    private void Start()
    {
        if (attacker == null || defender == null)
        {
            //First, we check to ensure we have both the scripts we need to run attached. Throw an error into the console if we do not!
            Debug.Log("You need to put both an Attacker and Defender on the GameLogic object!");
        }
        else
        {
            /*
             * We have both our attacker and defender, which means we can now do what we want with them.
             * Remember, these are just using the Adventurer parent class that Rogue and Mage inherit from to access their unique functions and variables.
             * Because we know both classes have access to all the same tools, we don't need to write a ton of unique code.
             */

            //The Attacker attacks the Defender using the Attack(target) function inherited from Adventurer.
            attacker.Attack(defender);

            //The defender moves using the MoveAdventurer() function inherited from Adventurer.
            defender.MoveAdventurer();
        }
    }
}
