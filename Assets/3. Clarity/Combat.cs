using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Nothing has changed about our Combat script other than putting it in the Clarity namespace so it can reference our new version of Adventurer.
 * Obviously, try to avoid having slightly different versions of the same scripts across different namespaces. This is just for the purposes of providing this example!
 */

namespace Clarity
{
    public class Combat : MonoBehaviour
    {
        public Adventurer attacker;
        public Adventurer defender;

        private void Start()
        {
            if (attacker == null || defender == null)
            {
                Debug.Log("You need to put both an Attacker and Defender on the GameLogic object!");
            }
            else
            {
                //The Attacker attacks the Defender using the Attack(target) function inherited from Adventurer.
                attacker.Attack(defender);

                //The defender moves using the MoveAdventurer() function inherited from Adventurer.
                defender.MoveAdventurer();
            }
        }
    }
}
