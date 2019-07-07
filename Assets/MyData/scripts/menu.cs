using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {


	public void restartGame () {
		SceneManager.LoadScene ("WalkingMan");
	}
	
	// Update is called once per frame
	public void exitGame() {
		Debug.Log("Exit nutton pressed");
		Application.Quit ();
	}
}
