using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour {

    public Button startButton; //Links to the buttons on the main menu.
    public Button instructionButton;

    public void StartGame()
    { //Loads the game while making the buttons unpressable to stop multiple loads.
        SceneManager.LoadSceneAsync("gameEnviroment", LoadSceneMode.Single);
        startButton.interactable = false;
        instructionButton.interactable = false;
    }
}
