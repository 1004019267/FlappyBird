using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 5;
    Animator animator;
    Rigidbody2D ri2;
    public GameObject end;
    int hp = 1;
    int num = 0;
    UI ui;
    public bool isDie = false;
    bool startGame;
    public event System.Action<int> ScoreHandler;
    // Use this for initialization
    void Start()
    {
        ui = GameObject.FindObjectOfType<UI>();
        ri2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        startGame = false;
        ri2.simulated = false;
    }
    public void Fly()
    {
        animator.Play("Bird3");
    }
    public void StartFly()
    {
        startGame = true;
        ri2.simulated = true;
    }
    // Update is called once per frame
    void Update()
    {      
        if (isDie == false&&startGame)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                ri2.velocity = Vector2.up * speed;
                animator.Play("Bird1");
            }        
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (hp > 0)
        {
            num++;
            if (ScoreHandler != null)
            {
                ScoreHandler(num);
            }
        }

    }
    //碰到柱子死亡   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (hp > 0)
        {
            hp--;
            if (hp <= 0)
            {
                isDie = true;
                animator.Play("Bird2");
                Air.scalespeed = 0;
                end.SetActive(true);
                int maxScore = PlayerPrefs.GetInt("maxScore");
                if (num > maxScore)
                {
                    maxScore = num;
                    PlayerPrefs.SetInt("maxScore", maxScore);
                }
                ui.lastScore1(num, maxScore);
            }

        }
        //碰到地面才减速
        //if (other.collider.CompareTag("Ground"))
        //{
        //    StartCoroutine(SlowDead(2));         
        //}
    }
    //IEnumerator SlowDead(float time)
    //{
    //    while (Time.timeScale > 0)
    //    {
    //        Time.timeScale = Mathf.Clamp(Time.timeScale - Time.unscaledDeltaTime / time, 0, 1);
    //        yield return 0;
    //    }
    //}
}
