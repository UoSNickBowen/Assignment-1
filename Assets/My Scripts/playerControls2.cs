using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls2 : MonoBehaviour
{

    private int locationMarker = 1; //Used to mark which row the player is on.
    public GameObject bullet; //Links to the bullet prefab.
    public GameObject[] bulletStock; //Array for disabled bullets.
    public int bulletLimit = 5; //Number of max bullets in the array.
    public Transform bulletFireLocation; //Links to a subobject linked to the player where bullets spawn from.

    void Start()
    {
        bulletStock = new GameObject[bulletLimit]; //Creates the array to size limit: bulletLimit.
        for (int x = 0; x < bulletLimit; x++) //For every empty array slot...
        {
            bulletStock[x] = Instantiate(bullet); //Instantiates a new bullet...
            bulletStock[x].SetActive(false); //And set it as de-activated, saving it until the player decides to shoot.
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            if (locationMarker != 2) // If the player isn't already on the top row...
            {
                movePlayer(true);
                // Move the player upwards one row.
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (locationMarker != 0) //If the player isn't already on the bottom row...
            {
                movePlayer(false);
                // Move the player down one row.
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = RespawnBullet(); //Returns any de-activated bullets, if any are present.
            if (bullet != null) //If the RespawnBullet returned a non-active bullet...
            {
                bullet.SetActive(true); //Set the bullet as active.
                bullet.transform.position = transform.position; //Move it to the fire location (Where the player currently is)
            }
        }

    }

    void movePlayer(bool upOrDown)
    {
        if (upOrDown) //Boolean is used to determine if the player was inputting up or down.
        { //Moves the player up a row
            transform.Translate(new Vector2(0, 10));
            locationMarker++;
        }
        else
        { //Moves the player down a row
            transform.Translate(new Vector2(0, -10));
            locationMarker--;
        }
    }

    private GameObject RespawnBullet()
    {
        for (int y = 0; y < bulletLimit; y++) //For every bullet in the array
        {
            if (!bulletStock[y].activeSelf) //If the bullet isn't active...
            {
                return bulletStock[y]; //Return it as a valid bullet.
            }
        }
        return null; //If no bullets are inactive, return null.
    }
}
