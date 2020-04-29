using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMechanism : MonoBehaviour
{
    int rotState;
    public int correct;
    public bool isCorrect;
    // Start is called before the first frame update
    void Start()
    {
        rotState = 1;
        isCorrect = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(rotState == 6)
        {
            rotState = 1;
        }
        else
        {
            rotState++;
        }
        if(rotState == correct)
        {
            isCorrect = true;
        }
        this.transform.Rotate(0, 60, 0, Space.Self);
    }
}
