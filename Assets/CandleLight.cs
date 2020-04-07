using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public Transform player;
    public GameObject light;
    // Start is called before the first frame update
    IEnumerator Start()
    {

        yield return new WaitForSeconds(20);
        gameObject.GetComponent<ParticleSystem>().Play();
        light.SetActive(true);
        yield return new WaitForSeconds(20);
        
        float dist = Vector3.Distance(player.position, transform.position);

        if(dist > 10)
        {
            gameObject.GetComponent<ParticleSystem>().Stop();
            light.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
