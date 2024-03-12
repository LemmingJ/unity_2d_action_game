using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeadCheck : MonoBehaviour
{
    public UnityEvent<Collider2D> onColliderEnter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // onColliderEnterに代入されたUnityEventを呼び出し、引数にotherを渡している
        onColliderEnter.Invoke(other);
    }
}
