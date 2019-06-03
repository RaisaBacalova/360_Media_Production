using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour {

    public GameObject quad;
    public GameObject sphereOne;
    private VideoPlayer video;
    private GvrAudioSource audioSource;

    void Awake()
    {
        video = quad.GetComponent<VideoPlayer>();
        audioSource = sphereOne.GetComponent<GvrAudioSource>();
    }

    public void OnClickPlay()
    {
        Debug.Log("'Play' was called");
        
        video.Play();
        audioSource.Play();
    }
}
