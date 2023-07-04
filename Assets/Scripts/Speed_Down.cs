using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Down : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player") return;
        Game_manager.instance.SlowDown();

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
