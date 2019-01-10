using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyCollision : MonoBehaviour {

    public bool haveLost = false;

    private void OnTriggerEnter2D(Collider2D col) //If the trigger collider connects with something...
    {
        if (col.gameObject.tag.Equals("bullet")) //If it collided with a bullet...
        {
            GameObject scorebox = GameObject.Find("Scorebox"); //Access the scorebox Game Object...
            score score = scorebox.GetComponent<score>(); //Take the score script from scorebox...
            score.scoreVal += 1; //And increment the value by 1.
            gameObject.SetActive(false); //The disable the bullet and the enemy.
            col.gameObject.SetActive(false);
        }

        if(col.gameObject.tag.Equals("wall")) //If it instead collided with a wall...
        {
            gameObject.SetActive(false); //Disable the enemy...
            SceneManager.LoadScene("gameOver", LoadSceneMode.Single); //And load the game over scene.
        }
    }
}
