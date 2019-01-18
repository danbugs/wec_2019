using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {
    
    public void PlayGame3() //for 3x3
    {
        Variables.setGridSize(3);
        SceneManager.LoadScene("Gameplay");
    }
    public void PlayGame10() // for 10x01
    {
        Variables.setGridSize(10);
        SceneManager.LoadScene("Gameplay");
    }
    public void PlayGame20() // for 20x20
    {
        Variables.setGridSize(20);
        SceneManager.LoadScene("Gameplay");
    }
    public void PlayGame30() // for 30x30
    {
        Variables.setGridSize(30);
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame3() //for 3x3
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(3);
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame10() // for 10x01
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(10);
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame20() // for 20x20
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(20);
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame30() // for 30x30
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(30);
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Debug.Log(" QUIT");

        Application.Quit();
    }


}
