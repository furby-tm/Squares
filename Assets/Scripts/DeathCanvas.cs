using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCanvas : MonoBehaviour {

	public GameObject deathCanvas;
	public static bool PlayerIsKilled = false;

	public void Awake() {
		deathCanvas = GameObject.Find("Canvas");
	}

	// Use this for initialization
	void Start () {
		deathCanvas.SetActive(false);
	}
}
