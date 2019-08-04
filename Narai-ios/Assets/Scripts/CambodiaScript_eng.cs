using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambodiaScript_eng : MonoBehaviour {

    void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-2.3_eng");
	}

    public void OnBackToHome(){
       SceneManager.LoadScene ("2Menu_eng");
    }

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2-2_eng");
	}

	public void OnPushTo1(){
		PlayerPrefs.SetInt("QR Result", 28);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo2(){
		PlayerPrefs.SetInt("QR Result", 29);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo3(){
		PlayerPrefs.SetInt("QR Result", 30);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo4(){
		PlayerPrefs.SetInt("QR Result", 31);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo6(){
		PlayerPrefs.SetInt("QR Result", 32);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo7(){
		PlayerPrefs.SetInt("QR Result", 33);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushTo8(){
		PlayerPrefs.SetInt("QR Result", 34);
		SceneManager.LoadScene ("2.3N_Description");
	}
}
