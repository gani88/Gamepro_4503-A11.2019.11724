using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public float minIncrease = 5f;
    public float maxIncrease = 10f;
    float increase;

    private void Start()
    {
        increase = Random.Range(minIncrease, maxIncrease);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject Player = collision.gameObject;
            Movement playerScript = Player.GetComponent<Movement>();

            if (playerScript)
            {
                playerScript.jumpPower += increase;
            }
            Destroy(gameObject);
        }
    }
}
