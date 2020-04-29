using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTrigger : MonoBehaviour
{
    public GameObject dial1;
    public GameObject dial2;
    public GameObject dial3;
    public GameObject dial4;
    public GameObject dial5;
    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("asdfad");
        if(dial1.GetComponent<LockMechanism>().isCorrect)
        {
            gate.GetComponent<GateMove>().openGate();
        }
    }
}
