using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoStop : MonoBehaviour {

    public GameObject quad;
    public GameObject sphereOne;
    private VideoPlayer video;
    private GvrAudioSource audioSource;

    void Awake()
    {
        video = quad.GetComponent<VideoPlayer>();
        audioSource = sphereOne.GetComponent<GvrAudioSource>();
    }

    public void OnClicStop()
    {
        Debug.Log("'Stop' was called");

        video.Pause();
        audioSource.Pause();
    }
}

