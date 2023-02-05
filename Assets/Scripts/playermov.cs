using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class playermov : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public int score = 0;
    public Text scoreText;
    private bool IsDead;
    public GameObject panel;
    AudioSource audioSo;
    public AudioClip succes;
    void Start()
    {
        audioSo = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, Time.fixedDeltaTime * speed);
        }
        if(IsDead)
        {
            Time.timeScale = 0;
        }
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "score")
        {
            score++;
            audioSo.PlayOneShot(succes);
            scoreText.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsDead = true;
        panel.SetActive(true);
    }

    public void tryagain()
    {
        SceneManager.LoadScene(1);
    }
    public void exitt()
    {
        Application.Quit();
    }

}
