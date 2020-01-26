using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTouched : MonoBehaviour
{
    private bool touched;
    // Start is called before the first frame update
    void Start()
    {
        touched = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
