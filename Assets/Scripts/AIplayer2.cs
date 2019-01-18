using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIplayer2 : MonoBehaviour
{
    static int[,] grid = GameGrid.grid;
    static int[,] basinCalculations = GameGrid.basinCalculations;
    static int[,] location = new int[grid.GetLength(0), grid.GetLength(1)];
    int spot;
    int basins = grid.GetLength(0);
    int row;
    int col;
    int valueGo;
    int valueGB;
    static bool gameOver = false;
    // Use this for initialization
    void Start()
    {
        spot = Random.Range(0, basins * basins - 1);
        row = (int)(spot / basins);
        col = spot % basins;
        Debug.Log("First location: "+row + " " + col);
        location[row, col] = 1;
        if (Variables.getIsSimulation())
        {
            play(row, col);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void play(int urow, int ucol)
    {
        float[] positionHit = new float[2];
        positionHit[0] = Main.getRowPoints(urow);
        positionHit[1] = Main.getColPoints(ucol);
        valueGo = grid[urow, ucol];
        valueGB = basinCalculations[urow, ucol];
        Debug.Log(valueGB);
        if (valueGo == 1)
        {
            Debug.Log(urow + " " + ucol);
            Debug.Log("game over");
            gameOver = true;
        }
        while (gameOver == false)
        {
            if (valueGB >= 4)
            {
                badNum(urow, ucol);
            }
            else
            {
                goodNum(urow, ucol);
            }
        }

    }
    void goodNum(int urow, int ucol)
    {

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
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 2:
                    Nrow = urow - 1;
                    Ncol = ucol + 1;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 3:
                    Nrow = urow;
                    Ncol = ucol + 1;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 4:
                    Nrow = urow + 1;
                    Ncol = ucol + 1;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 5:
                    Nrow = urow + 1;
                    Ncol = ucol;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 6:
                    Nrow = urow + 1;
                    Ncol = ucol - 1;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 7:
                    Nrow = urow;
                    Ncol = ucol - 1;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;
                case 8:
                    Nrow = urow - 1;
                    Ncol = ucol - 1;
                    if (!cornerCheck(Nrow, Ncol, grid))
                    {
                        goodNum(urow, ucol);
                    }
                    location[row, col] = 1;

                    break;

            }
            Debug.Log("New location GN:" + Nrow + " " + Ncol);
            if (cornerCheck(Nrow, Ncol, grid))
            {
                if (location[Nrow, Ncol] == 0)
                {
                    done = true;
                    play(Nrow, Ncol);
                }
            }
        }

    }
    bool cornerCheck(int newrow, int newcol, int[,] array)
    {
        bool valid = false;
        if (!(newrow >= array.GetLength(0)) && !(newcol >= array.GetLength(1)) && newrow >= 0 && newcol >= 0)
        {
            valid = true;

        }
        return valid;
    }
    void badNum(int urow, int ucol)
    {
        int[,] coords = new int[1, 2];
        coords = newSpot(location);

        if (coords[1, 1] <= row + 1 && coords[1, 1] >= row - 1)
        {
            if (cornerCheck(urow, ucol, grid))
            {
                coords = newSpot(location);
            }
        }
        else if (coords[1, 2] <= col + 1 && coords[1, 2] >= col + 1)
        {
            if (cornerCheck(urow, ucol, grid))
            {
                coords = newSpot(location);
            }
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
        Debug.Log("New location BN:" + coords[1,1] + " "+coords[1,2]);

        return coords;
    }


}
