using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class aspectRatio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //get aspect ratio
        //try to meet 9:16
        float screenWidthInUnits =  5f * (float)((float)Screen.width / (float)Screen.height);
        print(screenWidthInUnits);
        print(Screen.width);
        print(Screen.height);

        print("testing " + screenWidthInUnits);
        GetComponent<CinemachineVirtualCamera>().m_Lens.OrthographicSize *= (2.8f / screenWidthInUnits);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
