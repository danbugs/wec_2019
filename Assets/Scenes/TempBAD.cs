using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempBAD : MonoBehaviour {

    int badSpot(int[,] array, int row, int col)
    {
        int basins = array.GetLength(0);
        int[,] coords = new int[1, 2];
        coords = newSpot(array);
 
        if(coords[1,1] <= row + 1 && coords[1, 1] >= row - 1)
        {
            coords = newSpot(array);
        } else if (coords[1, 2] <= col + 1 && coords[1, 2] >= col + 1)
        {
            coords = newSpot(array);
        } else
        {
            //ALL GOOD, GO GO
        }
    }

    int [,] newSpot(int[,] location)
    {
        int basins = location.GetLength(0);
        int[,] coords = new int[1, 2];
        int row, col;
        int spot;

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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
