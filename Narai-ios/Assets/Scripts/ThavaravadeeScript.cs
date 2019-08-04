using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThavaravadeeScript : MonoBehaviour {

	void Start(){
		PlayerPrefs.SetString("current scene", "2.3-2-2.2");
	}

	public void OnBackToHome(){
        SceneManager.LoadScene ("2Menu");
       }

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2-2");
	}

	public void OnPushToThummajak(){
		PlayerPrefs.SetInt("QR Result", 15);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPrapim(){
		PlayerPrefs.SetInt("QR Result", 16);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToVitakkamutha(){
		PlayerPrefs.SetInt("QR Result", 17);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPravisanu(){
		PlayerPrefs.SetInt("QR Result", 18);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPranusbodee(){
		PlayerPrefs.SetInt("QR Result", 19);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToPoonpunnakornkosa(){
		PlayerPrefs.SetInt("QR Result", 20);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToRoobthavaravadee(){
		PlayerPrefs.SetInt("QR Result", 21);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToYompatiharn(){
		PlayerPrefs.SetInt("QR Result", 22);
		SceneManager.LoadScene ("2.3N_Description");
	}

	public void OnPushToKarntangkai(){
		PlayerPrefs.SetInt("QR Result", 23);
		SceneManager.LoadScene ("2.3N_Description");
	}




}
