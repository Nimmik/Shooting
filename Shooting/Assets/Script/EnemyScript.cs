﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	Rigidbody rb;
	public GameObject player;
	Vector3 dir;

	// Use this for initialization
	void Start () {

		rb = this.gameObject.GetComponent<Rigidbody> ();
		rb.AddForce (new Vector3 (0, 0, -100));

		var x = Random.Range (-50, 50);
		var z = Random.Range (-30, 30);
		rb.AddForce (new Vector3 (x, 0, z));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.LookRotation (rb.velocity);
	}

	void OnCollisionEnter(Collision other){
		if (!other.gameObject.CompareTag("GameBoundary")){
			//Explosion Animation
			Debug.Log("notgameboundary");
		}
		Destroy (this.gameObject);
	}
}
