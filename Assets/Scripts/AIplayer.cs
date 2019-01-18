using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIplayer : MonoBehaviour {
    [SerializeField]
    GameObject click;
    static int[,] grid = GameGrid.grid;
    static int[,] basinCalculations = GameGrid.basinCalculations;
    static int[,] location = new int[grid.GetLength(0), grid.GetLength(1)];
    int spot;
    int basins = grid.GetLength(0);
    int row;
    int col;
    int value;
    static bool gameOver = false;
    // Use this for initialization
    void Start () {
        spot = Random.Range(0, basins * basins - 1);
        row = (int)(spot / basins);
        col = spot % basins;
        location[row, col] = 1;
        if(Variables.getIsSimulation())
        {
            play(row, col);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
    void play(int urow, int ucol){
        float[] positionHit = new float[2];
        positionHit[0] = Variables.getRowPoints(urow);
        positionHit[1] = Variables.getColPoints(ucol);
        Instantiate(click, new Vector2(positionHit[0], positionHit[1]), Quaternion.identity);
        value = basinCalculations[urow, ucol];
        if(value == 0){
            Debug.Log("game over");
            gameOver = true;
        }
        while (gameOver == false)
        {
            if (value >= 4)
            {
                badNum(urow, ucol);
            }
            else
            {
                goodNum(urow, ucol);
            }
        }

    }
    void goodNum(int urow, int ucol){
       
        int Nrow = 0;
        int Ncol = 0;
        bool done = false;
        while (done == false)
        {
            int random = Random.Range(1, 8);
            switch (random)
            {
                case 1:
                    Nrow = urow - 1;
                    Ncol = ucol;
                    break;
                case 2:
                    Nrow = urow - 1;
                    Ncol = ucol + 1;
                    break;
                case 3:
                    Nrow = urow;
                    Ncol = ucol + 1;
                    break;
                case 4:
                    Nrow = urow + 1;
                    Ncol = ucol + 1;
                    break;
                case 5:
                    Nrow = urow + 1;
                    Ncol = ucol;
                    break;
                case 6:
                    Nrow = urow + 1;
                    Ncol = ucol - 1;
                    break;
                case 7:
                    Nrow = urow;
                    Ncol = ucol - 1;
                    break;
                case 8:
                    Nrow = urow - 1;
                    Ncol = ucol - 1;
                    break;

            }
            if(location[Nrow, Ncol] == 0){
                done = true;
                play(Nrow, Ncol);
            }
        }

    }
    void badNum(int urow, int ucol)
    {
        int[,] coords = new int[1, 2];
        coords = newSpot(location);

        if (coords[1, 1] <= row + 1 && coords[1, 1] >= row - 1)
        {
            coords = newSpot(location);
        }
        else if (coords[1, 2] <= col + 1 && coords[1, 2] >= col + 1)
        {
            coords = newSpot(location);
        }
        else
        {
            play(coords[1, 1], coords[1, 2]);
        }
    }
    int[,] newSpot(int[,] array)
    {
        int[,] coords = new int[1, 2];
        do
        {
            spot = Random.Range(0, basins * basins - 1);
            row = (int)(spot / basins);
            col = spot % basins;
        } while (location[row, col] == 1);

        coords[1, 1] = row;
        coords[1, 2] = col;

        return coords;
    }


}
