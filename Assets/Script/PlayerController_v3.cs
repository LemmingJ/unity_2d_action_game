using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerController_v3 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim = null;
    [SerializeField] private float jumpForse;
    private int onGround = 0;
    private int isJumping = 0;
    private int jumpTime = 0;
    private float vectorY = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround == 1)
        {
            if (Input.GetKey(KeyCode.Space) && jumpTime < 15)
            {
                Jump();
                isJumping = 1;
            }
            else
            {
                isJumping = 0;
            }
        } 
        else if (isJumping == 1)
        {
            if (Input.GetKey(KeyCode.Space) && jumpTime < 15)
            {
                Jump();
            }
            else
            {
                isJumping = 0;
            }
        }
    }

    void Jump()
    {
        vectorY = jumpForse;
        rb.velocity = new Vector2(0 , vectorY);
        vectorY = 0;
        jumpTime++;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        onGround = 1;
        anim.SetBool("jump", false);
    }

    private void OnTriggerExit2D()
    {
        onGround = 0;
        anim.SetBool("jump", true);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "OutArea")
        {
            Debug.Log("detection");
            StartCoroutine("Corou1");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private IEnumerator Corou1()
    {
        rb.simulated = false;
        anim.SetBool("dead", true);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HeadEventHandler(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            // 衝突したオブジェクトの名前をログに出力
            Debug.Log("block");
            jumpTime = 20;
        }
    }

    // 後方向の衝突検出イベントを受け取るためのメソッド
    public void FootEventHandler(Collider2D collider)
    {
        
        // 衝突したオブジェクトの名前をログに出力
        jumpTime = 0;
        
    }
}
