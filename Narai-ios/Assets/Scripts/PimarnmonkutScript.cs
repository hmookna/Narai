using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PimarnmonkutScript : MonoBehaviour {

    public void OnBackToHome(){
    	SceneManager.LoadScene ("2Menu");
    }
	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2Antique");
	}

	public void OnPushToBeforeHistory(){
		SceneManager.LoadScene ("2.3-2-2.1");
	}

	public void OnPushToThavaravadee(){
		SceneManager.LoadScene ("2.3-2-2.2");
	}

	public void OnPushToCambodian(){
		SceneManager.LoadScene ("2.3-2-2.3");
	}

	public void OnPushToAyutthaya(){
    	SceneManager.LoadScene ("2.3-2-2.4");
    }

    public void OnPushToRattanagosin(){
    	SceneManager.LoadScene ("2.3-2-2.5");
    }

    public void OnPushToRama4(){
        SceneManager.LoadScene ("2.3-2-2.6");
    }

}
