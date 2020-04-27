using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxSound : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public AudioSource audioSource;
    public AudioClip sound;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!anim.GetCurrentAnimatorStateInfo(0).IsTag("0"))
        {
            audioSource.PlayOneShot(sound);
            anim.Play("Rotate");
        }
    }
}
