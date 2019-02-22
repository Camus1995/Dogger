using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D () {

		Debug.Log ("You Won");
        Score.current_Score += 10;
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);

	}





}
