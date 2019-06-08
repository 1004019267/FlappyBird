using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Post : MonoBehaviour
{
    public Transform post;
    float t = 3;
   public bool comePost;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (comePost)
        {
            t += Time.deltaTime * Air.scalespeed;
            if (t > 1.5)
            {
                var go = Instantiate(post);
                go.transform.position = new Vector3(39 + t, Random.Range(6, -4), 0);
                t = 0;
            }
        }

    }
}
