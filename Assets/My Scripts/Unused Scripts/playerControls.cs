using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerControls : MonoBehaviour
{
    int locationMarker;
    Boolean upOrDown; //True for up, false for down.
    public GameObject bullet;
    public Transform bulletFireLocation;


    void Start()
    {
        locationMarker = 1; //Used to determine where the player is. Top, middle or bottom.
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { //Remeber to use KeyCode for C#
            if (locationMarker != 2)
            {
                upOrDown = true;
                movePlayer(upOrDown);
                // Moves the player up if they're not already at the top.
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (locationMarker != 0)
            {
                upOrDown = false;
                movePlayer(upOrDown);
                // Moves the player down if they're not already at the bottom.
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerFire(); //Simple shoot function call.
        }
    }

    private void movePlayer(Boolean upOrDown)
    {
        if (upOrDown)
        { //If player is moving up

            locationMarker++;
        }
        else
        { //Else player is moving down
            locationMarker--;
        }
    }

    public void playerFire()
    {
        Instantiate(bullet, bulletFireLocation.position, Quaternion.identity);
    }

}