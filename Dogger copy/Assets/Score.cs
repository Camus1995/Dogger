using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    public static int current_Score = 0;
    public Text scoreText; 

    void Start ()
    {

        scoreText.text = "Score: " + current_Score.ToString();


    }


}
