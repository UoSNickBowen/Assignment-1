using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour {

    private void Update()
    {
        transform.Translate(10 * Time.deltaTime, 0, 0); //Makes the bullet translate to the right.
    }
    private void OnTriggerEnter2D(Collider2D col) //When it collides with another game object...
    {
        if (col.gameObject.tag.Equals("disableField")) //If that object was the disableField, an area offscreen...
        {
            gameObject.SetActive(false); //Disable the bullet for re-use.
        }
    }



}