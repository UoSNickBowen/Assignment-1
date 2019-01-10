using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRotate : MonoBehaviour {

	public int rotateSpeed = 10; 
	public float movementSpeed = 1;

	void FixedUpdate () {
		transform.Rotate(rotateSpeed, 0, 0); //Rotates on the x axis by set integer. This gives the pheradacytls their spin!
		transform.Translate(-movementSpeed * Time.deltaTime, 0, 0); //-movement to move them left. Enemy speed was changed in Unity inspector.
	}
}
