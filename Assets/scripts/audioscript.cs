using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{

    public AudioSource audiosource;
    public AudioClip jump;



    public void PlaySound()
    {
        audiosource.Play();
    }

    public void StopSound()
    {
        audiosource.Stop();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audiosource.PlayOneShot(jump);
    }
}
