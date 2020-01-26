using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public ParticleSystem ps;
    public float speed;
    private float dir;
    public GameObject resetText;
    public AudioSource deathSound;
    public AudioSource pointSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * dir * Time.deltaTime, rb.velocity.y);
    }

    public void scoreIncrement()
    {
        GetComponent<gameManaging>().scoreUpdate();
        pointSound.Play();
    }

    public void die()
    {
        playerScore.highScore = GetComponent<gameManaging>().highScore;
        Instantiate(ps, new Vector3 (transform.position.x,transform.position.y,-5.0f), Quaternion.identity);
        gameObject.SetActive(false);
        resetText.SetActive(true);
        deathSound.Play();
    }

}
