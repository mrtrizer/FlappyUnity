using UnityEngine;
using System.Collections;

public class CheckpointCtrl : MonoBehaviour {

	public delegate void Checkpoint();
	public static event Checkpoint OnCheckpoint;

	void OnTriggerEnter2D(Collider2D collider) {
		if (OnCheckpoint != null)
			OnCheckpoint ();
	}
}
