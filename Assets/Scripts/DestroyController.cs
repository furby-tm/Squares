using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	public GameObject theCanvas;
	public DeathCanvas canvas;
	public GameObject bigExplosionEffect;
	public GameObject player;
	public Rigidbody rb;
	public int MoveSpeed = 4;
	public int MaxDist = 10;
	public int MinDist = 1; 

	// Use this for initialization
	void Start () {
		canvas = GetComponent<DeathCanvas>();
		player = GameObject.FindGameObjectWithTag("Player");
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 direction = (player.transform.position - transform.position).normalized;
		rb.MovePosition(transform.position + transform.forward * MoveSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			DestroyObject(other.gameObject);
			DeathCanvas.PlayerIsKilled = true;
	  	}
	}
}