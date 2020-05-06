using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is for storing globals 
public static class puzzle2Global
{
    // These determine state of the puzzle
    public static bool isOpened = false;
    public static bool pedestal1Check = false;
    public static bool pedestal2Check = false;
    public static bool pedestal3Check = false;

    // These are the objects for the puzzle
    public static GameObject pedestal1;
    public static GameObject pedestal2;
    public static GameObject pedestal3;
    public static GameObject door;

}
