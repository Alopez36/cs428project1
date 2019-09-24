using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeScene2 : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Button2");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            Debug.Log("Scene 3 Loaded");

    }
}