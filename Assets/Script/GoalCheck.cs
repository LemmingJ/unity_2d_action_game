using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�^�OPlayer�ƏՓ˂�����V�[����؂�ւ�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("detection");
        SceneManager.LoadScene("Stage02");
    }
}
