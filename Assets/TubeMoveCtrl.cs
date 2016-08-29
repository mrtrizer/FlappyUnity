using UnityEngine;
using System.Collections;

public class TubeMoveCtrl : MonoBehaviour {
	public float moveSpeed = 1;

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-moveSpeed * Time.deltaTime, 0.0f);
	}
}
