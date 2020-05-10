using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void Load()
    {
        LatestGame.latest = true;
        SceneManager.LoadScene("Game");
    }

    public void LoadPlayer()
    {
        LatestGame.latest = false;
        SceneManager.LoadScene("Game");
    }
}
