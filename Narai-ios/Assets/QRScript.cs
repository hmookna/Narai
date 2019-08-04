using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QRScript : MonoBehaviour {

	public void OnBackToPreviousPage(){
	    if(PlayerPrefs.GetInt("Language") == 0) {
    	    SceneManager.LoadScene ("2Menu ");
        } else {
            SceneManager.LoadScene ("2Menu_eng");
        }
	}
}

