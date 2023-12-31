using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dec_Coins : MonoBehaviour
{
    [SerializeField] float turnspeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player") return;

        Game_manager.instance.DecrementScore();
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnspeed * Time.deltaTime);
    }
}
