using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	public GameObject theCanvas;
	public DeathCanvas canvas;
	public GameObject bigExplosionEffect;

	// Use this for initialization
	void Start () {
		canvas = GetComponent<DeathCanvas>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Explosion.playerHasDied = true;
			DestroyObject(other.gameObject);
			DeathCanvas.PlayerIsKilled = true;
	  }
	}
}
