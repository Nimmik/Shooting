using UnityEngine;
using System.Collections;
using GravityShooting;

public class EnemySpawner : MonoBehaviour {
	public GameObject Enemy;
	public float NextSpawnTime = 0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (NextSpawnTime <= Time.time){
			Spawn ();
			NextSpawnTime = Time.time + Random.Range(Constants.EnemySpawnIntervalFrom,Constants.EnemySpawnIntervalTo);
		}
	}

	void Spawn(){
		var x = Random.Range (Constants.LeftBound, -Constants.LeftBound);
		Instantiate (Enemy, new Vector3(x,0,Constants.TopOfTheMap),Enemy.transform.rotation);
	}
}
