using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualGrid : MonoBehaviour {
    [SerializeField]
    GameObject tile;
    [SerializeField]
    GameObject basin;

    [SerializeField]
    GameObject num0;
    [SerializeField]
    GameObject num1;
    [SerializeField]
    GameObject num2;
    [SerializeField]
    GameObject num3;
    [SerializeField]
    GameObject num4;
    [SerializeField]
    GameObject num5;
    [SerializeField]
    GameObject num6;
    [SerializeField]
    GameObject num7;
    [SerializeField]
    GameObject num8;

    int[,] grid = GameGrid.grid;
    int[,] basinCalculations = GameGrid.basinCalculations;

	// Use this for initialization
	void Start () {
        Camera.main.orthographicSize = grid.GetLength(0)/2 + 1;
        int rowCounter = 0;
        int colCounter = 1;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (grid[i, j] == 1)
                {
                    Instantiate(basin, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter,-(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                    Instantiate(tile, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                }
                else
                {
                    switch(basinCalculations[i, j])
                    {
                        case 1:
                            Instantiate(num1, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(num2, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(num3, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 4:
                            Instantiate(num4, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 5:
                            Instantiate(num5, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 6:
                            Instantiate(num6, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 7:
                            Instantiate(num7, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        case 8:
                            Instantiate(num8, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                        default:
                            Instantiate(num0, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
                            break;
                    }
                    Instantiate(tile, new Vector2((Camera.main.orthographicSize - .5f) + rowCounter, -(Camera.main.orthographicSize + .5f) + colCounter), Quaternion.identity);
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
