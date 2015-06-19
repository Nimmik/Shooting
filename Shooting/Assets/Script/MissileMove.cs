using UnityEngine;
using System.Collections;

public class MissileMove : MonoBehaviour {
	public GameObject player;
	Vector3 dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		dir = player.transform.position - this.gameObject.transform.position;
		this.gameObject.GetComponent<Rigidbody> ().AddForce (dir);
	}
}
