using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public Transform firePosition1;
	//apublic Transform firePosition2;
	public GameObject missile;
	public GameObject player;
	public float NextShootTime = 1f;
	int distanceCheckLayer;
	Vector3 dir;

	// Use this for initialization
	void Start () {
		distanceCheckLayer = LayerMask.NameToLayer ("distanceCheck");
	}
	
	// Update is called once per frame
	void Update () {
		if (NextShootTime <= Time.time) {
			dir = firePosition1.position - player.transform.position;
			Fire (dir);
			NextShootTime = Time.time + 3f;
		}
	}

	void Fire(Vector3 dir){
		if (!Physics.Linecast (this.gameObject.transform.position, player.transform.position, distanceCheckLayer)) {
			Instantiate(missile, firePosition1.position, Quaternion.LookRotation(dir));
			//Instantiate(missile, firePosition2.position, this.gameObject.transform.rotation);
		}
	}
}
