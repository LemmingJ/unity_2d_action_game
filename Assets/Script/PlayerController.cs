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
        //D�L�[����������E�����֐i��&animation
        if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
            //�����𔽓](�E)
            transform.localScale = new Vector3(2, 2, 1);
            anim.SetBool("run", true);

        }
        //A�L�[���������獶�����֐i��&animation
        else if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
            //�����𔽓](��)
            transform.localScale = new Vector3(-2, 2, 1);
            anim.SetBool("run", true);
        }
        //�����Ȃ�������~�܂�&animation
        else
        {
            playerSpeed = 0;
            anim.SetBool ("run", false);
        }

        //�X�y�[�X����������W�����v
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //rb2d.velocity = new Vector2(playerSpeed, jump);
        //}

        //�ړ������s
        rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
    }
}
