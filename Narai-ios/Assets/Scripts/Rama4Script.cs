using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rama4Script : MonoBehaviour {

    void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-2.6");
	}

    public void OnBackToHome(){
		SceneManager.LoadScene ("2Menu");
	}

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2-2");
	}

    public void OnPushTo1(){
		PlayerPrefs.SetInt("QR Result", 39);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo2(){
		PlayerPrefs.SetInt("QR Result", 40);
		SceneManager.LoadScene ("2.3N_Description");
	}

}
