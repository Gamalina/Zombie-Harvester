using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    protected Rigidbody2D rigidbody2d;
    public Sprite carLeft;
    public Sprite carUp;
    public Sprite carRight;
    public Sprite carDown;
    // Update is called once per frame

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = carLeft;
            
        }
        if (Input.GetKeyDown("w")) 
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = carUp;
        }
        if (Input.GetKeyDown("d"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = carRight;
        }
        if (Input.GetKeyDown("s"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = carDown;
        }
        rigidbody2d.transform.Translate(Input.GetAxis("Horizontal") * 1f * Time.deltaTime, 0f, 0f);
        rigidbody2d.transform.Translate(0f, Input.GetAxis("Vertical") * 1f * Time.deltaTime, 0f);
    }


}
