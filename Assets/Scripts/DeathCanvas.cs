using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCanvas : MonoBehaviour {

public GameObject deathCanvas;
public bool PlayerIsKilled = false;

public void Awake() {
	deathCanvas = GameObject.Find("Canvas");
}

	// Use this for initialization
	void Start () {
		deathCanvas.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (PlayerIsKilled == true)
		{
			deathCanvas.SetActive(true);
			deathCanvas.SetActive(true);
	  }
	}
}
