using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float turnspeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player") return;

        Game_manager.instance.IncrementScore();
        Destroy(gameObject);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, turnspeed * Time.deltaTime);
    }
}
