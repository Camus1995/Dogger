using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public GameObject timeisUp, restartButton;

    void Start()
    {
        
    }

  
    void Update()
    {
        if (TimeLeft.timeleft <= 0)
        {

            Time.timeScale = 0;
            timeisUp.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);


        }

    }

    public void restartScene ()
    {
        timeisUp.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        Time.timeScale = 1;
        TimeLeft.timeleft = 10f;
        SceneManager.LoadScene("Level1");

    }

}
