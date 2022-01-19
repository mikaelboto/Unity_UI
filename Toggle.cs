using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code8UIToggle : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Toggle>().isOn = Screen.fullScreen;
    }
    public void OnValueChange()
    {
        if (GetComponent<Toggle>().isOn)
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;

        else 
            Screen.fullScreenMode = FullScreenMode.Windowed;
    }
}