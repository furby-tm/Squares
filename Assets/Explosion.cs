using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public GameObject bigExplosionEffect;
	public GameObject player;
	public static bool playerHasDied;

	// Use this for initialization
	void Start () {
		bigExplosionEffect = GameObject.Find("BigExplosionEffect");
		bigExplosionEffect.SetActive (false);
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHasDied = true) {
			Debug.Log ("EXPLODE AND DIE!");
			bigExplosionEffect.SetActive (true);
		}
	}
}
