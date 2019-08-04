using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntiqueScript_eng : MonoBehaviour {

    public void OnBackToHome(){
       SceneManager.LoadScene ("2Menu_eng");
    }

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2Menu_eng");
	}

	public void OnPushToChunpisarn(){
		SceneManager.LoadScene ("2.3-2-1_eng");
	}

	public void OnPushToPimarnmongkut(){
		SceneManager.LoadScene ("2.3-2-2_eng");
	}
}
