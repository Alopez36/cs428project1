using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlayVideo2 : MonoBehaviour, IVirtualButtonEventHandler
{
    public UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject vbBtnObj;
    private bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Video2PlayButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (!flag)
        {
            videoPlayer.Play();
            flag = true;
        }
        else
        {
            videoPlayer.Pause();
            flag = false;
        }

        Debug.Log("Scene 3 Loaded");

    }
}
