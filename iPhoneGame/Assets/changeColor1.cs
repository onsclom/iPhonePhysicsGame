using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor1 : MonoBehaviour
{
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float curAmnt = playerScore.color;
        curAmnt += offset;

        if (curAmnt >= 1f)
            curAmnt -= 1f;

        Color curColor;
        curColor = Color.HSVToRGB(curAmnt, .5f, 1f);

        GetComponent<SpriteRenderer>().color = curColor;
    }
}
