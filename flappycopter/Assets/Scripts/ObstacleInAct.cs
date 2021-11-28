using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInAct : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-4, 0);

    // Start is called before the first frame update
    void Start()
    {
        float range = 1;
        GetComponent<Rigidbody2D>().velocity = veloc;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
