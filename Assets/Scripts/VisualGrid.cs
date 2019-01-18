using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualGrid : MonoBehaviour {
    [SerializeField]
    GameObject tile;
    [SerializeField]
    GameObject basin;

    int[,] grid = GameGrid.grid;

	// Use this for initialization
	void Start () {
        Camera.main.orthographicSize = grid.GetLength(0)/2;
        int rowCounter = 0;
        int colCounter = 1;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (grid[i, j] == 1)
                {
                    Instantiate(basin, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter,-(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                }
                else
                {
                    Instantiate(tile, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter,-(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                }
                colCounter++;
                
            }
            rowCounter--;
            colCounter = 1;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
