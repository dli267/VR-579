using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveThing : MonoBehaviour
{
    [SerializeField]
    GameObject objectToMove = null;
    [SerializeField]
    float move = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        objectToMove.transform.position += new Vector3(0, 0, move); 
    }
}
