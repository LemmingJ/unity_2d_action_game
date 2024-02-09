using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerController_v3 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim = null;
    [SerializeField] private int moveSpeed;
    [SerializeField] private int jumpForse;
    private int isJumping = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && (isJumping == 0))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForse, ForceMode2D.Impulse);
        Debug.Log("jump");
    }

    private void OnTriggerStay2D()
    {
        isJumping = 0;
        anim.SetBool("jump", false);
    }

    private void OnTriggerExit2D()
    {
        isJumping = 1;
        anim.SetBool("jump", true);
    }
}
