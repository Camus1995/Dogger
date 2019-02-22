using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{

    Text text;
    public static float timeleft = 10f;


    void Start()
    {
        text = GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft < 0)
            timeleft = 0;
        text.text = "Time Left: " + Mathf.Round(timeleft);
        
    }
}
