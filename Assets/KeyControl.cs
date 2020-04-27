using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour

{
    public AudioClip sound;
    public AudioSource audioSource;
    private Animator anim;
    public string whichAnimation;
    // Start is called before the first frame update
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
            anim.Play(whichAnimation);
        }  
    }
}
