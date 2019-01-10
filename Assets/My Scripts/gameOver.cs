using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {

	public Button mainmenuButton; //Links to the main menu button.

	public void mainMenu() { // Used to load the main menu while disabling the button to stop multiple clicks.
		SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
		mainmenuButton.interactable = false;
	}
}
