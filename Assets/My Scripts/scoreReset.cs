using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreReset : MonoBehaviour {

	void Update () {
        score.scoreVal = 0; //Super simple piece of code on the main menu to reset the static value of score.
        //Score kept carrying over from game to game so I had to do a reset on the main menu.

    }

}
