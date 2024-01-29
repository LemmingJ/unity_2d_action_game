using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerController_v3 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int moveSpeed;
    [SerializeField] private int jumpForse;
    private int isJumping = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && (isJumping == 0))
        {
            Jump();
            Debug.Log("jump");
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForse, ForceMode2D.Impulse);
    }

    private void OnTriggerStay2D()
    {
        isJumping = 0;
        //Debug.Log("on");
    }

    private void OnTriggerExit2D()
    {
        isJumping = 1;
        Debug.Log("off");
    }
}
