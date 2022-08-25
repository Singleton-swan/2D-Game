using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //Room Camera
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;


    private void update()
    {
        //Room Camera
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3( currentPosX, transform.position.y, transform.position.z), ref velocity, speed);
    
        //Follow Player
        //transform.position = new Vector3(transform.position.x, 0, 0);   
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }
}
