using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Variables
{
    public static int gridSize;
    public static bool isSimulation;
    public static float[] row = new float[getGridSize()];
    public static float[] col = new float[getGridSize()];
       
    public static int getGridSize()
    {
        return gridSize;
    }
    public static void setGridSize(int input)
    {
        gridSize = input;
    }
    public static bool getIsSimulation()
    {
        return isSimulation;
    }
    public static void setIsSimulation(bool input)
    {
        isSimulation = input;
    }
    public static float getRowPoints(int random)
    {   
        int index = (int)(random / gridSize);
        return row[index];
    }
    public static void setRowPoints(int index, float r)
    {
        row[index] = r;
    }
    public static float getColPoints(int random)
    {
        int index = random % gridSize;
        return col[index];
    }
    public static void setColPoints(int index, float c)
    {
        col[index] = c;
    }
}
