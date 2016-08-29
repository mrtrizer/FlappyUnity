using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointBoxCtrl : MonoBehaviour {

	private int points;
	private Text text;

	void Start() {
		text = GetComponent<Text> ();
	}

	void Checkpoint() {
		points++;
		text.text = "" + points;
	}

	void OnEnable() {
		CheckpointCtrl.OnCheckpoint += Checkpoint;
	}

	void OnDisable() {
		CheckpointCtrl.OnCheckpoint -= Checkpoint;
	}
}
