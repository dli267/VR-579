using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Controller : MonoBehaviour
{
    // These objects are initialized through the inspector
    [SerializeField]
    GameObject pedestal1 = null;
    [SerializeField]
    GameObject pedestal2 = null;
    [SerializeField]
    GameObject pedestal3 = null;
    [SerializeField]
    GameObject door = null;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize puzzle pedestals and door game objects
        puzzle2Global.pedestal1 = pedestal1;
        puzzle2Global.pedestal2 = pedestal2;
        puzzle2Global.pedestal3 = pedestal3;
        puzzle2Global.door = door;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
