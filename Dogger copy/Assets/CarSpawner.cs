using UnityEngine;

public class CarSpawner : MonoBehaviour {
	
	public GameObject car1;
	public float spawnDelay = .3f;
	float nextTimetoSpawn = 0f;
	public Transform[] SpawnPoints;
    public float t;


	void Update () {

        t = Time.time;

		if (nextTimetoSpawn <= Time.time) {

			SpawnCar ();
			nextTimetoSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar() {

		int randomIndex = Random.Range (0, SpawnPoints.Length);
		Transform SpawnPoint = SpawnPoints [randomIndex];

		Instantiate (car1, SpawnPoint.position, SpawnPoint.rotation);

	}


}
