using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code9UIDropDown : MonoBehaviour
{
    
    void Start()
        
    {
        Resolution[] resolutions = Screen.resolutions;

        foreach (var res in resolutions)
        {
            GetComponent<Dropdown>().options.Add(new Dropdown.OptionData ( res.width + " x " + res.height + " @ " + res.refreshRate));


        }
    }
    

     public void SetResolution()
    {
        Resolution[] resolutions = Screen.resolutions;
        int index = GetComponent<Dropdown>().value;

        Screen.SetResolution (resolutions[index].width, resolutions[index].height, FullScreenMode.ExclusiveFullScreen, resolutions[index].refreshRate);
    }
}