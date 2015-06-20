using UnityEngine;
using System.Collections;
using GravityShooting;

public class SkyboxCameraRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.left * Time.deltaTime * Constants.SkyboxRotateSpeed);
	}
}
