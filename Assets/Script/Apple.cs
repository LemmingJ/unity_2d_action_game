using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Apple : MonoBehaviour
{
    private Animator anim = null;
    //Score script = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log(other.gameObject.name);
            //script = other.GetComponent<Score>();
            //script.score += 10;
            GameScore.score += 10;
            Destroy(GetComponent<CircleCollider2D>());
            anim.SetBool("get", true);
        }
    }

    public void OnAnimetionEnd()
    {
        Destroy(this.gameObject);
    }
}
