using UnityEngine;
using System.Collections;

public class DistanceCheck : MonoBehaviour {
	Rigidbody rb;
	Animator anim;
	// Use this for initialization
	void Start () {
		rb = this.transform.parent.GetComponent<Rigidbody> ();
		anim = this.transform.parent.FindChild("Enemy1").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerStay(Collider other){
		var dir = this.transform.parent.position - other.transform.position;
		dir.z = 0;
		rb.AddForce (dir.normalized/4);
		anim.SetFloat("Rotation", dir.x);
	}
	void OnTriggerExit(Collider other){
		anim.SetFloat("Rotation", 0);
	}
}
