using UnityEngine;
using UnityEngine.SceneManagement;

public class LanguageMenu : MonoBehaviour {

	#region Public Methods

	public void OnBackToPreviousPage(){
		SceneManager.LoadScene ("2Menu");
	}

	public void SetEnglish()
	{
	    PlayerPrefs.SetInt("Language", 1);
	    SceneManager.LoadScene ("2Menu_eng");
		Localize.SetCurrentLanguage(SystemLanguage.English);
//		LocalizeImage.SetCurrentLanguage();
	}

	public void SetThai()
	{
	    PlayerPrefs.SetInt("Language", 0);
	    SceneManager.LoadScene ("2Menu");
		Localize.SetCurrentLanguage(SystemLanguage.Thai);
//		LocalizeImage.SetCurrentLanguage();
	}

	public void SetDucth()
	{
		Localize.SetCurrentLanguage(SystemLanguage.Dutch);
//		LocalizeImage.SetCurrentLanguage();
	}

	#endregion Public Methods
}
