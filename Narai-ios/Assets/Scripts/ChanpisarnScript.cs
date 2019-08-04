using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanpisarnScript : MonoBehaviour {


	void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-1");
	}

	public void OnBackToHome(){
    	SceneManager.LoadScene ("2Menu");
    }

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2Antique");
	}

	public void OnPushToThummas(){
		PlayerPrefs.SetInt("QR Result", 10);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToLompok(){
		PlayerPrefs.SetInt("QR Result", 11);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPaiLhumSobJeen(){
		PlayerPrefs.SetInt("QR Result", 12);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToFnSiam(){
		PlayerPrefs.SetInt("QR Result", 13);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToNaraiHistry(){
		PlayerPrefs.SetInt("QR Result", 14);
		SceneManager.LoadScene ("2.3N_Description");
	}

}
