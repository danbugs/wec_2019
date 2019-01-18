using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {
    public static float[] row;
    public static float[] col;

    public void PlayGame3() //for 3x3
    {
        Variables.setGridSize(3);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void PlayGame10() // for 10x01
    {
        Variables.setGridSize(10);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void PlayGame20() // for 20x20
    {
        Variables.setGridSize(20);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void PlayGame30() // for 30x30
    {
        Variables.setGridSize(30);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame3() //for 3x3
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(3);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame10() // for 10x01
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(10);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame20() // for 20x20
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(20);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }
    public void SimPlayGame30() // for 30x30
    {
        Variables.setIsSimulation(true);
        Variables.setGridSize(30);
        row = new float[Variables.getGridSize()];
        col = new float[Variables.getGridSize()];
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Debug.Log(" QUIT");

        Application.Quit();
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static float getRowPoints(int random)
    {
        int index = (int)(random / Variables.getGridSize());
        return row[index];
    }
    public static void setRowPoints(int index, float r)
    {
        row[index] = r;
    }
    public static float getColPoints(int random)
    {
        int index = random % Variables.getGridSize();
        return col[index];
    }
    public static void setColPoints(int index, float c)
    {
        col[index] = c;
    }


}
