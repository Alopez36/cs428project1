using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeScene : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;


    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Button");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            Debug.Log("Scene 2 Loaded");
        


    }
}