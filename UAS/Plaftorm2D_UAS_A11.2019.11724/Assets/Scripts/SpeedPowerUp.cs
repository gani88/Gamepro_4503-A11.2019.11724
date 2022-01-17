using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float increase = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject Player = collision.gameObject;
            Movement playerScript = Player.GetComponent<Movement>();

            if (playerScript)
            {
                playerScript.speed += increase;
            }
            Destroy(gameObject);
        }
    }
}
