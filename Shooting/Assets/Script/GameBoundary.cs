using UnityEngine;
using System.Collections;

public class GameBoundary : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		Destroy (other.gameObject);
	}

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
	}
}
