﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class dog : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.RightArrow))
			rb.MovePosition (rb.position + Vector2.right);
		else if (Input.GetKeyDown (KeyCode.LeftArrow))
			rb.MovePosition (rb.position + Vector2.left);
		else if (Input.GetKeyDown (KeyCode.UpArrow))
			rb.MovePosition (rb.position + Vector2.up);
		else if (Input.GetKeyDown (KeyCode.DownArrow))
			rb.MovePosition (rb.position + Vector2.down);
		
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Car1") {

			Debug.Log ("LOOOSER :v");
            Score.current_Score = 0;
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);


		}


	}
}
