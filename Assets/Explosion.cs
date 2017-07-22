using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public static GameObject bigExplosionEffect;
	public GameObject player;

	// Use this for initialization
	void Start () {
		bigExplosionEffect = GameObject.Find("BigExplosionEffect");
	}
	
	// Update is called once per frame
	void Update() {
	}
}
