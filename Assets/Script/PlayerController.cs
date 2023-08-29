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
        //D�L�[����������E�����֐i��
        if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
        }
        //A�L�[����������E�����֐i��
        else if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
        }
        //�����Ȃ�������~�܂�
        else
        {
            playerSpeed = 0;
        }

        //�X�y�[�X����������W�����v
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //rb2d.velocity = new Vector2(playerSpeed, jump);
        //}

        rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
            
    }
}
