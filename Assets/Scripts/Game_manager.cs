using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Game_manager : MonoBehaviour
{
    public int score;
    public static Game_manager instance;

    [SerializeField] Player_movement player_Movement;

    [SerializeField] Text coinsCollected;

    public void IncrementScore()
    {
        score++;
        coinsCollected.text = "Coins Collected : " + score;
        player_Movement.speed += player_Movement.speedInc;
    }

    public void DecrementScore() 
    { 
        score--;
        coinsCollected.text = "Coins Collected : " + score;
        player_Movement.speed -= player_Movement.speedInc;
    }


    public void SlowDown()
    {
        player_Movement.speed--;
    }

    public void HigherJump()
    {
        player_Movement.jumpForce = player_Movement.jumpForce + 30f;
    }

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
