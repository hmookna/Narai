using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Back(string scene){
//		SceneManager.LoadScene(scene, LoadSceneMode.Single);
		string prevScene = PlayerPrefs.GetString("current scene");
		SceneManager.LoadScene(prevScene);
	}

	public void takePicture(){
		
	}
}
