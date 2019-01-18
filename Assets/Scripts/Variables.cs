using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Variables
{
    public static int gridSize;
    public static bool isSimulation;
    public static bool gridGenerated;
       
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
    public static bool getGridGenerated()
    {
        return gridGenerated;
    }
    public static void setGridGenerated(bool input)
    {
        gridGenerated = input;
    }
}
