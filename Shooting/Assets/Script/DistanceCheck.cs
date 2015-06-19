using UnityEngine;
using System.Collections;

public class DistanceCheck : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.transform.parent.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerStay(Collider other){
		var dir = this.transform.parent.position - other.transform.position;
		dir.z = 0;
		rb.AddForce (dir.normalized/4);
	}
}
