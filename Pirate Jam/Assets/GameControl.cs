using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public CanvasGroup victory;
    public CanvasGroup gameover;

    public GameObject player;
    private ShipBase playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = player.GetComponent<ShipBase>();
        victory.alpha = 0;
        gameover.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStats.getHealth() <= 0)
        {
            gameover.alpha = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == player)
        {
            Debug.Log("AMAZING JOB!");
            victory.alpha = 1;
        }
    }
}
