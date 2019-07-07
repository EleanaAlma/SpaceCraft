using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRWalking : MonoBehaviour {

	public Transform vrCamera;
	public float toggleAngle = 30.0f;
	public float speed = 3.0f;
	public bool moveForward;

	public CharacterController cc;


	// Use this for initialization
	public void Start(){
		cc = GetComponentInParent<CharacterController>();
	}
	
	// Update is called once per frame
	public void Update(){
		if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f){
			moveForward = true;
		} 
		else {
			moveForward = false;
		}
		if(moveForward){
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}
