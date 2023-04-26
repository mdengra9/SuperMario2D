using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool canShoot;
    public float powerUpDuration = 5;
    public float powerUpTimer = 0;

    public List<GameObject> enemiesInScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootPowerUp();

        if(Input.GetKeyDown(KeyCode.P))
        {
            KillAllEnemies();
        }
    }

    void ShootPowerUp()
    {
        if(canShoot)
        {
           if(powerUpTimer <= powerUpDuration) 
           {
            powerUpTimer += Time.deltaTime;
           }
           else
           {
            canShoot = false;
            powerUpTimer = 0;
           }
           
        }
    }

    void KillAllEnemies()
    {
        for (int i = 0; i < enemiesInScreen.Count; i++)
        {
            Destroy(enemiesInScreen[i]);
        }
    }
}
