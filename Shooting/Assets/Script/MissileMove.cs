using UnityEngine;
using System.Collections;

public class MissileMove : MonoBehaviour {
	public GameObject player;
	Vector3 dir;

	// Use this for initialization
	void Start () {
		dir = player.transform.position - this.gameObject.transform.position;
		this.gameObject.GetComponent<Rigidbody> ().AddForce (dir.normalized*300);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("EnemyShip") || other.gameObject.CompareTag ("EnemyShip")) {
			Destroy (this.gameObject);
			Destroy (other.gameObject);
		}
	}
}
