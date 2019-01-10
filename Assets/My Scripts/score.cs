using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    static public int scoreVal = 0; //Players current score is stored as scoreVal, 
    //and is accessed by enemies when they collide, and used on the game over screen 
    //as well as the scorebox on the game scene.
    public Text scoreText; //The textbox where the score is displayed on the game and game over screen.

	void FixedUpdate () {
        scoreText.text = "Enemies defeated: " + scoreVal.ToString(); //Updates constantly refreshing the text (I had to do this because calling the function 
        // from other scripts after increasing the score was causing issues.)
    }
}
