using UnityEngine;
using System.Collections;

public class SpawnCtrl : MonoBehaviour {

	private GameObject lastTube;
	public Object tubePrefab;
	public float maxRandomOffset = 4.0f;
	public float tubeDistance = 7.0f;
	private bool gameStarted = false;

	// Update is called once per frame
	void Update () {
		if (gameStarted)
		if ((lastTube == null) || (transform.position.x - lastTube.transform.position.x > tubeDistance)) {
			var randomOffset = new Vector3(0, Random.Range (-maxRandomOffset, maxRandomOffset));
			lastTube = Instantiate (tubePrefab, transform.position + randomOffset, Quaternion.identity) as GameObject;
		}
	}

	void GameStart() {
		gameStarted = true;
	}

	void OnEnable() {
		BirdCtrl.OnGameStart += GameStart;
	}

	void OnDisable() {
		BirdCtrl.OnGameStart -= GameStart;
	}
}
