using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIplayer : MonoBehaviour {
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
        play(row, col);
    }

    // Update is called once per frame
    void Update () {
		
	}
    void play(int urow, int ucol){
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
    void goodNum(int row, int col){
       
        int Nrow = 0;
        int Ncol = 0;
        bool done = false;
        while (done == false)
        {
            int random = Random.Range(1, 8);
            switch (random)
            {
                case 1:
                    Nrow = row - 1;
                    Ncol = col;
                    break;
                case 2:
                    Nrow = row - 1;
                    Ncol = col + 1;
                    break;
                case 3:
                    Nrow = row;
                    Ncol = col + 1;
                    break;
                case 4:
                    Nrow = row + 1;
                    Ncol = col + 1;
                    break;
                case 5:
                    Nrow = row + 1;
                    Ncol = col;
                    break;
                case 6:
                    Nrow = row + 1;
                    Ncol = col - 1;
                    break;
                case 7:
                    Nrow = row;
                    Ncol = col - 1;
                    break;
                case 8:
                    Nrow = row - 1;
                    Ncol = col - 1;
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
