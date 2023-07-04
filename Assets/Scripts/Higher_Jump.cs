using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Higher_Jump : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player") return;
        Game_manager.instance.HigherJump();
        
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
