using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCanvas : MonoBehaviour {

	public GameObject deathCanvas;
	private GameObject player;
	public static bool PlayerIsKilled = false;

	public void Awake() {
		deathCanvas = GameObject.Find("Canvas");
		player = GameObject.Find("Player");
	}

	// Use this for initialization
	void Start () {
		deathCanvas.SetActive(false);
	}
}
