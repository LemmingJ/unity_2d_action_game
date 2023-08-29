using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    //public float jump = 4f;
    private float playerSpeed;

    Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Dキーを押したら右方向へ進む
        if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
        }
        //Aキーを押したら右方向へ進む
        else if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
        }
        //何もなかったら止まる
        else
        {
            playerSpeed = 0;
        }

        //スペースを押したらジャンプ
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //rb2d.velocity = new Vector2(playerSpeed, jump);
        //}

        rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
            
    }
}
