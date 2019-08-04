using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RattanagosinScript : MonoBehaviour {

    void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-2.5");
	}

    public void OnBackToHome(){
		SceneManager.LoadScene ("2Menu");
	}

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2-2");
	}

    public void OnPushTo1(){
        PlayerPrefs.SetInt("QR Result", 41);
    	SceneManager.LoadScene ("2.3N_Description");
	}

}
