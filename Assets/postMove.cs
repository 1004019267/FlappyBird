using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postMove : MonoBehaviour {
    public int speed;
    Bird bird;
	// Use this for initialization
	void Start () {
        bird = FindObjectOfType<Bird>();
	}
	
	// Update is called once per frame
	void Update () {     
  transform.position -= Vector3.right * Time.deltaTime * speed*Air.scalespeed;
        if (Vector3.Distance(transform.position,bird.transform.position)>30)
        {
            Destroy(this.gameObject);
        }      
	}
   
}
