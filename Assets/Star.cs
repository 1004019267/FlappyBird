using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Star : MonoBehaviour {
    Bird bird;
    Post post;
	// Use this for initialization
	void Start () {       
        post = FindObjectOfType<Post>();
        bird = FindObjectOfType<Bird>();
        bird.Fly();
        this.gameObject.GetComponent<Button>().onClick.AddListener(()=> {
            post.comePost = true;
            bird.StartFly();
        Destroy(this.gameObject);
        } );		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Destroy(this.gameObject);
        }
	}
}
