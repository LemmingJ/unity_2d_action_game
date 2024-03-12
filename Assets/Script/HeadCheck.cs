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
        // onColliderEnter‚É‘ã“ü‚³‚ê‚½UnityEvent‚ğŒÄ‚Ño‚µAˆø”‚Éother‚ğ“n‚µ‚Ä‚¢‚é
        onColliderEnter.Invoke(other);
    }
}
