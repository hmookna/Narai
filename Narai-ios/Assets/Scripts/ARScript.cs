using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARScript : MonoBehaviour {

    void Start(){
    	PlayerPrefs.SetString("current scene", "2.1_AR_Scanner");
    }

	public void OnBackToHome(){
	    if(PlayerPrefs.GetInt("Language") == 0) {
	        SceneManager.LoadScene ("2Menu");
        } else {
            SceneManager.LoadScene ("2Menu_eng");
        }

	}

	public void OnBackToPreviousPage(){
    	if(PlayerPrefs.GetInt("Language") == 0) {
    	    SceneManager.LoadScene ("2.1_before");
        } else {
            SceneManager.LoadScene ("2.1_before_eng");
        }
    }
}
