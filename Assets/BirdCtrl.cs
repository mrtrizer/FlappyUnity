using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BirdCtrl : MonoBehaviour {
	private Rigidbody2D rigidbody;
	public int flapVelocity = 5;
	public GameObject tutor;
	public delegate void GameStart();
	public static event GameStart OnGameStart;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (rigidbody.isKinematic) {
				rigidbody.isKinematic = false;
				tutor.SetActive (false);
				if (OnGameStart != null)
					OnGameStart ();
			}
			rigidbody.velocity = Vector2.up * flapVelocity;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (!collider.CompareTag("Checkpoint"))
			SceneManager.LoadScene ("menu");
	}
}
