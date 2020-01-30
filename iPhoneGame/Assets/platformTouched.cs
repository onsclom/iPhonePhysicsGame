using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTouched : MonoBehaviour
{
    private bool touched;
    private float color = .5f;
    private bool colorAscending = true;
    // Start is called before the first frame update
    void Start()
    {
        touched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (color >= 1)
        {
            colorAscending = false;
        }
        else if (color <= 0)
        {
            colorAscending = true;
        }

        if (colorAscending)
            color += .01f;
        else
            color -= .01f;

        Color curColor;
        if (touched)
            curColor = Color.HSVToRGB(color, .5f, .3f);
        else 
            curColor = Color.HSVToRGB(color, .5f, 1f);

        GetComponent<SpriteRenderer>().color = curColor;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player" && !touched)
        {
            touched = true;
            GetComponent<SpriteRenderer>().color = Color.gray;
            other.gameObject.GetComponent<playerController>().scoreIncrement();
        }
    }
}
