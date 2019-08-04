//DataSetLoader
//Developed by Alessandro Mondaini, Red Frog Digital Limited, Manchester, United Kingdom
//Free to use, improve and distribute but NOT reselling.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class dataSetCopier : MonoBehaviour 
{
	public string nextScene = "";
	WWW xmlPosition;
	WWW datPosition;
	string SetXml; 
	string SetDat; 
	string filePath;
	bool isRunning = false;
	public bool isEditor;
	public string localPath = "";
	
	[System.Serializable]
	public enum options {Local, SDCard};
	public options dataLocation;
	string shortName;
	public List<string> dataSetName;
	string DataSetFolderLocation;
	public bool runOnce = false;


	void Awake(){

		if(!runOnce){
			if(PlayerPrefs.HasKey("dataSetPresent")){
				PlayerPrefs.DeleteKey("dataSetPresent");
			}
		}

		DataSetFolderLocation = Application.streamingAssetsPath+"/QCAR/";


		if(dataLocation==options.Local)
			isEditor=true;
		else
			isEditor=false;
	}

	void Start(){


		#if UNITY_ANDROID


		if(!PlayerPrefs.HasKey("dataSetPresent")){

			if(!isRunning)
				StartCoroutine (copyDataSet());
		}

		else{

			if(!string.IsNullOrEmpty(nextScene))
				Application.LoadLevel(nextScene);
			else
				Application.LoadLevel(1);
		}

		#endif

		#if UNITY_IPHONE
		if(!string.IsNullOrEmpty(nextScene))
			Application.LoadLevel(nextScene);
		else
			Application.LoadLevel(1);
		#endif
	}

	IEnumerator copyDataSet(){

		isRunning=true;

		for(int i = 0; i<dataSetName.Count;i++){

			if(isEditor)
				SetDat = "File:///"+DataSetFolderLocation+dataSetName[i]+".dat";
			else
				SetDat = DataSetFolderLocation+dataSetName[i]+".dat";

			datPosition = new WWW(SetDat);
			yield return datPosition;
			
			if(isEditor)
				File.WriteAllBytes(localPath+dataSetName[i]+".dat", datPosition.bytes );
			else
				File.WriteAllBytes(Application.persistentDataPath+"/"+dataSetName[i]+".dat", datPosition.bytes );
		}

		yield return new WaitForEndOfFrame();

		for(int i = 0; i<dataSetName.Count;i++){

			if(isEditor)
				SetXml = "File:///"+DataSetFolderLocation+dataSetName[i]+".xml";
			else
				SetXml = DataSetFolderLocation+dataSetName[i]+".xml";

			xmlPosition = new WWW(SetXml);
			yield return xmlPosition;
			
			if(isEditor)
				File.WriteAllBytes(localPath+dataSetName[i]+".xml", xmlPosition.bytes );
			else
				File.WriteAllBytes(Application.persistentDataPath+"/"+dataSetName[i]+".xml", xmlPosition.bytes );
		}

		yield return new WaitForEndOfFrame();

		PlayerPrefs.SetInt("dataSetPresent",0);

		/*
		if(!isEditor){

			Debug.Log("DataSet succesfully copied on your SD Card");

			if(!string.IsNullOrEmpty(nextScene))
				Application.LoadLevel(nextScene);
			else
				Application.LoadLevel(1);
		}
		else{

			Debug.Log("DataSet succesfully copied on your Local Folder");

			if(!string.IsNullOrEmpty(nextScene))
				Application.LoadLevel(nextScene);
			else
				Application.LoadLevel(1);
	}
	*/
	

}

}