using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundSensor : MonoBehaviour
{
    private PlayerrController controller;
    public bool isGrounded;

    SFXManager sfxManager;
    SoundManager soundManager;

    void Awake ()
    {
        controller = GetComponentInParent<PlayerrController>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            controller.anim.SetBool("IsJumping", false);
        }

        else if(other.gameObject.layer == 6)
        {
            Debug.Log("Enemy Down");

            sfxManager.GoombaDeath();

            EnemyGoomba goomba = other.gameObject.GetComponent<EnemyGoomba>();
            goomba.Die();

        }

        if(other.gameObject.tag == "DeadZone");
        {
            Debug.Log("U dead");

            soundManager.StopBGM();
            sfxManager.MarioDeath();
            SceneManager.LoadScene(2);
        }
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            controller.anim.SetBool("IsJumping", false);
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = false;
            controller.anim.SetBool("IsJumping", true);
        }
    }
}
