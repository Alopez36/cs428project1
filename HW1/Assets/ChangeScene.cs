using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeScene : MonoBehaviour, IVirtualButtonEventHandler
{

    public Boolean flag;
    public GameObject vbBtnObj;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Button");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        flag = true;
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if(flag)
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);

        Debug.Log("Button released");
    }
}