using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class photosphere : MonoBehaviour{

	const float nSecond = 5f;
	float timer = 0;
	bool entered = false;
	string scene;


	public void SendMessage(string sceneName)
	{
		scene = sceneName;
	}

	public void PointerEnter()
	{
		entered = true;
	}

	public void PointerExit()
	{
		entered = false;
	}
	void Update () {
		//If pointer is pointing on the object, start the timer
		if (entered)
		{
			//Increment timer
			timer += Time.deltaTime;

			//Load scene if counter has reached the nSecond
			if (timer > nSecond)
			{
				//SceneManager.LoadScene("SceneName");
				Debug.Log ("hover");
				SceneManager.LoadScene (scene);
			}
		}
		else
		{
			//Reset timer when it's no longer pointing
			timer = 0;
			//Debug.Log ("exit");
		}
	}
	public void movetoScene(string scene){
		Debug.Log ("move");
		SceneManager.LoadScene (scene);
	}

}
