using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVDOAR : MonoBehaviour
{
    VideoPlayer vdo;

    void Start()
    {
        vdo = GetComponent<VideoPlayer>();
    }

    void Update()
    {

        if (GetComponent<MeshRenderer>().enabled && !vdo.isPlaying)
        {
            vdo.Play();
            Debug.Log("started");
        }

        else if (!GetComponent<MeshRenderer>().enabled)
        {
            vdo.Stop();
            Debug.Log("stopped");
        }
    }
}