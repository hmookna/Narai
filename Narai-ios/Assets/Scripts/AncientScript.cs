using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AncientScript : MonoBehaviour {

	void Start(){
		PlayerPrefs.SetString("current scene", "2.3-1Ancient");
	}

	public void OnBackToHome(){
		SceneManager.LoadScene ("2Menu");
	}

	public void OnBackToPrevPage(){
    	SceneManager.LoadScene ("2Menu");
    }

	public void OnPushToRubkhakmueng(){
		PlayerPrefs.SetInt("QR Result", 2);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTokampangmueng(){
		PlayerPrefs.SetInt("QR Result", 3);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToThunggebnam(){
		PlayerPrefs.SetInt("QR Result", 4);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToTongprakung(){
		PlayerPrefs.SetInt("QR Result", 5);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPrajaohao(){
		PlayerPrefs.SetInt("QR Result", 6);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToChanpisarn(){
		PlayerPrefs.SetInt("QR Result", 7);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPimarnmongkut(){
		PlayerPrefs.SetInt("QR Result", 8);
		SceneManager.LoadScene ("2.3N_Description");
	}
		
	public void OnPushToPrapatieb(){
		PlayerPrefs.SetInt("QR Result", 9);
		SceneManager.LoadScene ("2.3N_Description");
	}

}
