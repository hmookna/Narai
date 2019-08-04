using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingMovies : MonoBehaviour {

	private string movPath = "14.mp4";

	// Use this for initialization
	void Start () {
		StartCoroutine(PlayStreamingVideo(movPath));
	}

	private IEnumerator PlayStreamingVideo(string url)
	{
		Handheld.PlayFullScreenMovie(url, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		Debug.Log("Video playback completed.");
	}
}
