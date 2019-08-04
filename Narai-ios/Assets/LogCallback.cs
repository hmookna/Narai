using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogCallback : MonoBehaviour {

	public Text log ;
	public Text stack ;
	void OnEnable() {
		Application.logMessageReceived += HandleLog;
	}
	void OnDisable() {
		Application.logMessageReceived -= HandleLog;
	}
	void HandleLog(string logString, string stackTrace, LogType type) {
		log.text = logString;
		stack.text = stackTrace;
	}

}
