using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlayVideo1 : MonoBehaviour, IVirtualButtonEventHandler
{
    public UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject vbBtnObj;
    public UnityEngine.Video.VideoPlayer videoPlayer2;
    public GameObject vbBtnObj2;
    private int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Video1PlayButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vbBtnObj = GameObject.Find("Video2PlayButton");
        vbBtnObj2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if(flag > 1)
        {
            videoPlayer.Play();
            videoPlayer2.Pause();

            flag = 0;
        }
        else
        {
            videoPlayer2.Play();
            videoPlayer.Pause();
            flag = 2;
        }
        
        Debug.Log("Scene 3 Loaded");

    }
}
