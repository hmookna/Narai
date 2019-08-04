using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beforeHistryScript : MonoBehaviour {

	void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-2.1");
	}

    public void OnBackToHome(){
       SceneManager.LoadScene ("2Menu_eng");
    }

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2-2");
	}

	public void OnPushTo1(){
		PlayerPrefs.SetInt("QR Result", 24);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo2(){
		PlayerPrefs.SetInt("QR Result", 25);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo3(){
		PlayerPrefs.SetInt("QR Result", 26);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo4(){
		PlayerPrefs.SetInt("QR Result", 27);
		SceneManager.LoadScene ("2.3N_Description");
	}

}
