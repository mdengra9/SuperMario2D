using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    BoxCollider2D boxCollider;
    SFXManager sfxManager;
    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            sfxManager.Coin();
        }
    }
}
