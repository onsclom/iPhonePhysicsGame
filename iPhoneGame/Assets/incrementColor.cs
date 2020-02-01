using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incrementColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        float curAmnt = playerScore.color;
        curAmnt += .5f;

        if (curAmnt >= 1f)
            curAmnt -= 1f;

        Color curColor;
        curColor = Color.HSVToRGB(curAmnt, .5f, 1f);

        GetComponent<Camera>().backgroundColor = curColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerScore.color += .1f * Time.deltaTime;

        if (playerScore.color >= 1f)
        {
            playerScore.color = 0f;
        }
    }
}