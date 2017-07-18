using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

	public float speed = 1;

	void Update() {
//Move cube from (0, 0, 0) to (5, 0, 0) and back.
transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 5), transform.position.y, transform.position.z);
}

}
