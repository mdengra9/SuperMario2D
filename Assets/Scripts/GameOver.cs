using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{    
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

     public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
