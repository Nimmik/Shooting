using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public Transform firePosition1;
	public Transform firePosition2;
	public GameObject missile;
	public GameObject player;
	public float NextShootTime = 1f;
	int distanceCheckLayer;

	// Use this for initialization
	void Start () {
		distanceCheckLayer = LayerMask.NameToLayer ("distanceCheck");
	}
	
	// Update is called once per frame
	void Update () {
		if (NextShootTime <= Time.time) {
			Fire ();
			NextShootTime = Time.time + 1f;
		}
	}

	void Fire(){
		if (!Physics.Linecast (this.gameObject.transform.position, player.transform.position, distanceCheckLayer)) {
			Instantiate(missile, firePosition1.position, this.gameObject.transform.rotation);
			Instantiate(missile, firePosition2.position, this.gameObject.transform.rotation);
		}
	}
}
