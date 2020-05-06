using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject correctTrigger = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * Continusly checking if the correct block is on the corresponding pedestal 
     * 
     * Note: had to use OnTriggerStay instead of OnTriggerEnter due to a bug where 
     * if the player accidently bumped the the wrong cube against a pedestal that
     * had correct block on top already, it would reregister that pedestalcheck as false 
     * because the last collided object triggering check
     * 
     */
    private void OnTriggerStay(Collider other)
    {
        
        if (!puzzle2Global.isOpened)
        {
            if (other.gameObject == correctTrigger)
            {
                pedestalCheck(true); // the correct object was placed
               // Debug.Log("the object is correct! " + other.gameObject.name);
            }
            else
            {
                pedestalCheck(false); // the incorrect object was placed 
            }
        }
    }

    /*
     * This checks changes the state of the current pedestal. Each time the state changes,
     * it checks if all the pedestals; in the case they are all correct, the door "opens" 
     * 
     */
    private void pedestalCheck(bool check)
    {
        if (this.gameObject == puzzle2Global.pedestal1)
        {
            puzzle2Global.pedestal1Check = check;
        } else if(this.gameObject == puzzle2Global.pedestal2)
        {
            puzzle2Global.pedestal2Check = check;
        } else if(this.gameObject == puzzle2Global.pedestal3)
        {
            puzzle2Global.pedestal3Check = check;
        }

        // If all pedestals contain correct object
        if (puzzle2Global.pedestal1Check && puzzle2Global.pedestal2Check && puzzle2Global.pedestal3Check)
        {
            //Debug.Log("Correct Answer!");
            puzzle2Global.isOpened = true;
            puzzle2Global.door.transform.position += new Vector3(0, 8, 0); // "open" door by moving it up
        }
    }
}
