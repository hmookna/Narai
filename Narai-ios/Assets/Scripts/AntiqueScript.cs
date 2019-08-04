using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntiqueScript : MonoBehaviour {

    public void OnBackToHome(){
       SceneManager.LoadScene ("2Menu");
    }

	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2Menu");
	}

	public void OnPushToChunpisarn(){
		SceneManager.LoadScene ("2.3-2-1");
	}

	public void OnPushToPimarnmongkut(){
		SceneManager.LoadScene ("2.3-2-2");
	}

}
