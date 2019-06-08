using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    public static int scalespeed=1;
    public float speed;
    public bool recycle;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -16)
        {
            if (recycle)
            {
                transform.position = new Vector3(56.21f, transform.position.y, transform.position.z);
            }
            else
            {
                Destroy(this.gameObject);
            }

        }
        transform.position -= Vector3.right * Time.deltaTime * speed*scalespeed;

    }
}
