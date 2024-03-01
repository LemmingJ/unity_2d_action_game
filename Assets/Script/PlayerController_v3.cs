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
    [SerializeField] private int jumpForse;
    private int isJumping = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "OutArea")
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
}
