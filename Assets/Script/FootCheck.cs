using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FootCheck : MonoBehaviour
{
    // onColliderEnter�Ƃ���public��UnityEvent���`
    // �擪��o���������ł��邱�Ƃɒ���
    // ����UnityEvent�͈�����Collider�����n�܂�
    public UnityEvent<Collider2D> onColliderEnter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Unity�̓����C�x���g�֐���OnTriggerEnter���\�b�h���`
    private void OnTriggerStay2D(Collider2D other)
    {
        // onColliderEnter�ɑ�����ꂽUnityEvent���Ăяo���A������other��n���Ă���
        onColliderEnter.Invoke(other);
    }
}
