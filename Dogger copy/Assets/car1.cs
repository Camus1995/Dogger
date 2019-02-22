using UnityEngine;


public class car1 : MonoBehaviour {
	public float minSpeed = 8f;
	public float maxSpeed = 12f;

	public Rigidbody2D rb;
	float speed = 1f;
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 forward = new Vector2 (transform.right.x, transform.right.y);
		rb.MovePosition (rb.position + forward * Time.fixedDeltaTime * speed);
		
	}

	void Start () {
		speed = Random.Range (minSpeed, maxSpeed);



	}
}




