using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    private float playerSpeed;

    private Animator anim = null;

    Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Dキーを押したら右方向へ進む&animation
        if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
            //向きを反転(右)
            transform.localScale = new Vector3(2, 2, 1);
            anim.SetBool("run", true);

        }
        //Aキーを押したら左方向へ進む&animation
        else if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
            //向きを反転(左)
            transform.localScale = new Vector3(-2, 2, 1);
            anim.SetBool("run", true);
        }
        //何もなかったら止まる&animation
        else
        {
            playerSpeed = 0;
            anim.SetBool ("run", false);
        }

        //スペースを押したらジャンプ
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //rb2d.velocity = new Vector2(playerSpeed, jump);
        //}

        //移動を実行
        rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
    }
}
