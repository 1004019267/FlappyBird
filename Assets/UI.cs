using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {
    Text score;
    Text lastScore;
    Bird bird;
    // Use this for initialization
    void Start () {
        lastScore= transform.Find("Lose/num").GetComponent<Text>();
        score = transform.Find("Text").GetComponent<Text>();
        bird = GameObject.FindObjectOfType<Bird>(); bird.ScoreHandler += Score;
    }
    void OnDestroy()
    {
        bird.ScoreHandler -= Score;
    }
    public void Score(int num)
    {
        score.text = "Score" + num;
    }
    public void lastScore1(int num,int maxnum)
    {
        lastScore.text = "分数:" + num+"最高分"+maxnum;
    }
    // Update is called once per frame
    
    void Update () {
		
	}
}
