using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PimarnmonkutScript_eng : MonoBehaviour {

    public void OnBackToHome(){
    	SceneManager.LoadScene ("2Menu_eng");
    }
	public void OnBackToPrevPage(){
		SceneManager.LoadScene ("2.3-2Antique_eng");
	}

	public void OnPushToBeforeHistory(){
		SceneManager.LoadScene ("2.3-2-2.1_eng");
	}

	public void OnPushToThavaravadee(){
		SceneManager.LoadScene ("2.3-2-2.2_eng");
	}

	public void OnPushToCambodian(){
		SceneManager.LoadScene ("2.3-2-2.3_eng");
	}

	public void OnPushToAyutthaya(){
    	SceneManager.LoadScene ("2.3-2-2.4_eng");
    }

    public void OnPushToRattanagosin(){
    	SceneManager.LoadScene ("2.3-2-2.5_eng");
    }

    public void OnPushToRama4(){
        SceneManager.LoadScene ("2.3-2-2.6_eng");
    }
}
