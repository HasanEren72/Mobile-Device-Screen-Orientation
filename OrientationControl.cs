using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YonKontrol : MonoBehaviour
{
    [SerializeField]
    private ScreenOrientation defaultYon = ScreenOrientation.Portrait;

    void Start()
    {
        Screen.orientation = defaultYon;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        YonKontrolDegistir();     
    }

    void YonKontrolDegistir()
    {

        if (Input.deviceOrientation ==DeviceOrientation.LandscapeLeft || Input.deviceOrientation ==DeviceOrientation.LandscapeRight ||Input.deviceOrientation==DeviceOrientation.Portrait || Input.deviceOrientation ==DeviceOrientation.PortraitUpsideDown)
        {
            if (Screen.orientation != defaultYon)
            {
                Screen.orientation = defaultYon;
            }
        }
    }
}
