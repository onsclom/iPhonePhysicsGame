using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerObj;
    public ParticleSystem ps;

    void Start()
    {
        print("wee");
        print("wat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D other) {
        print("wow");
        if (other.gameObject.tag == "Player")
        {
            Instantiate(ps, new Vector3 (other.transform.position.x,other.transform.position.y,-5.0f), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
