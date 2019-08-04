using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beforeQRScript_eng : MonoBehaviour {

    public void OnBackToHome(){
        SceneManager.LoadScene ("2Menu_eng");
    }

    public void onPushToQRScanner(){
        SceneManager.LoadScene ("2.2_QR_Scanner");
    }
}
