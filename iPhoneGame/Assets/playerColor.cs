using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float curAmnt = playerScore.color;
        curAmnt += .75f;

        if (curAmnt >= 1f)
            curAmnt -= 1f;

        Color curColor;
        curColor = Color.HSVToRGB(curAmnt, 1f, 1f);

        GetComponent<SpriteRenderer>().color = curColor;
    }
}
