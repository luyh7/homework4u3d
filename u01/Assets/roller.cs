using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roller : MonoBehaviour {

	private Vector2 direction = new Vector2 (0.5f, 0.5f);
	// Use this for initialization
	void Start () {
	}
	void Update () {
		Debug.Log (direction.x+" "+direction.y);
		GameObject sphere = GameObject.Find ("SphereRoll");
		Vector3 spherePos = sphere.transform.position;
		sphere.transform.position = new Vector3 (spherePos.x + direction.x/10, spherePos.y, spherePos.z + direction.y/10);
	}
	
	void onCollisionEnter(Collision col){
		Debug.Log ("BOOM!!!!!!!!!!!");
		direction = new Vector2 (-direction.x, -direction.y);
		while(direction.x == 0 && direction.y == 0){
			direction = new Vector2 (-direction.x, -direction.y);
		}
	}

}
