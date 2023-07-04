using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    Player_movement player_movement;
    // Start is called before the first frame update
    private void Start()
    {
        player_movement = GameObject.FindObjectOfType<Player_movement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player_movement.Die();
        }
    }

}
