using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	public GameObject player;
	public Transform target;
	//public float speed= 0.05f;
	bool entered = false;


	public void move_player() {
		Debug.Log ("move");
		//player.transform.position =  Vector3.Lerp(player.transform.position, target.position, speed);
		player.transform.position = target.transform.position;
	
	}

}
