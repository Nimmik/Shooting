using UnityEngine;
using System.Collections;
using GravityShooting;

public class DistanceCheck : MonoBehaviour {
	Rigidbody rb;
	bool distanceChecking;
	public GameObject player;

	// Use this for initialization
	void Start () {
		rb = this.transform.parent.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (distanceChecking == false) {
			Vector3 origin = this.transform.parent.position;
			Vector3 dirForward = this.transform.parent.TransformDirection (Vector3.forward);
			Vector3 directionToPlayer = player.transform.position - origin;
			Vector3 Difference = dirForward - directionToPlayer;
			if (Difference.magnitude > Constants.LookAtPlayerThreshold) {
				rb.AddForce (new Vector3 (Difference.x>0?-0.5f:0.5f, 0, 0));
			}
		}
	}
	
	
	void OnTriggerStay(Collider other){
		if (!other.gameObject.CompareTag ("Missile")) {
			var dir = this.transform.parent.position - other.transform.position;
			dir.z = 0;
			rb.AddForce (dir.normalized / 4);
		}
	}

	void OnTriggerEnter(Collider other){
		if (!other.gameObject.CompareTag ("Missile")) {
			distanceChecking = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (!other.gameObject.CompareTag ("Missile")) {
			distanceChecking = false;
		}
	}
}
