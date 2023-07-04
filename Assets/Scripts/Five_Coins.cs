using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Five_Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player") return;

        Game_manager.instance.IncrementScore();
        Game_manager.instance.IncrementScore();
        Game_manager.instance.IncrementScore();
        Game_manager.instance.IncrementScore();
        Game_manager.instance.IncrementScore();
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
