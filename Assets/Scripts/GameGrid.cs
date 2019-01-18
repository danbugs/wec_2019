using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour {
    static int size = Variables.getGridSize();
    public static int[,] grid = new int[size,size];
    public static int[,] basinCalculations = new int[size, size];

	// Use this for initialization
	void Awake () {
        Randomize(grid);
        Debug.Log("Setup Grid");
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            Debug.Log("Row " + i);
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Debug.Log(grid[i, j]);
            }
        }

        Debug.Log("Check Basins");
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            Debug.Log("Row " + i);
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Debug.Log(Check(i, j, grid));
                basinCalculations[i, j] = Check(i, j, grid);
            }
        }

        int counter = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if(grid[i, j] == 1)
                {
                    counter++;
                }
            }
        }

        Debug.Log("Found " + counter + " basins");
	}
	
	// Update is called once per frame
	void Update () {
        var fps = 1.0f / Time.deltaTime;
        if (fps < 5)
        {
            Debug.Break();
        }
	}

    void Randomize(int[,] array)
    {
        int basins = array.GetLength(0);
        int counter = 0;
        int row = 0;
        int col = 0;
        int spot = 0;
            
        while (counter < basins) { 
            spot = Random.Range(0, basins * basins - 1);
            row = (int)(spot / basins);
            col = spot % basins;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if(array[row, col] == 0)
                    {
                        array[row, col] = 1;
                        counter++;
                    }
                }
            }
        }
    }

    int Check(int row, int col, int[,] array)
    {
        int totalbasins = 0;
        int Nrow = 0;
        int Ncol = 0;
        //case 1 
        Nrow = row - 1;
        Ncol = col;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 2
        Nrow = row - 1;
        Ncol = col + 1;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 3
        Nrow = row;
        Ncol = col + 1;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 4
        Nrow = row + 1;
        Ncol = col + 1;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 5
        Nrow = row + 1;
        Ncol = col;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 6
        Nrow = row + 1;
        Ncol = col - 1;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 7
        Nrow = row;
        Ncol = col - 1;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        //case 8
        Nrow = row - 1;
        Ncol = col - 1;
        totalbasins = totalbasins + BasinCheck(Nrow, Ncol, array);
        return totalbasins;

    }
    int BasinCheck(int newrow, int newcol, int[,]  array){
        int singlebasins = 0;
        if(!(newrow >= array.GetLength(0)) && !(newcol >= array.GetLength(1)) && newrow >= 0 && newcol >= 0){
            if(array[newrow, newcol] == 1){
                singlebasins = 1;
            }
            
        }
        return singlebasins;
    }
}
