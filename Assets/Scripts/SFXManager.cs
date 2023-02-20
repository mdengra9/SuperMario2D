using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip goombaDeath;
    public AudioClip marioDeath;
    public AudioClip coin;
    public AudioClip flag;

    private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void GoombaDeath() 
    {
        source.PlayOneShot(goombaDeath);
    }

    public void MarioDeath() 
    {
        source.PlayOneShot(marioDeath);
    }
    
    public void Coin() 
    {
        source.PlayOneShot(coin);
    }

    public void Flag()
    {
        source.PlayOneShot(flag);
    }

}
