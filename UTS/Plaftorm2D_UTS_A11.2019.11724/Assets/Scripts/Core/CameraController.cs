using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Dynamic Camera
    [SerializeField] private float speed;
    private float currentPostX;
    private Vector3 velocity = Vector3.zero;

    //Follow Player
    [SerializeField] private Transform player;
    [SerializeField] private float ahead;
    [SerializeField] private float cameraSpeed;
    private float look;


    private void Update()
    {
        //Dynamic
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPostX, transform.position.y, transform.position.z), ref velocity, speed);

        //Follow
        transform.position = transform.position = new Vector3(player.position.x + look, transform.position.y, transform.position.z);
        look = Mathf.Lerp(look, (ahead * player.localScale.x), Time.deltaTime * cameraSpeed);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPostX = _newRoom.position.x;
    }
}
