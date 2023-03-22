using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //lets player object be selected in unity
    public GameObject player;
    //this will be used to set position of the camera
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //moves camera to directly on top of player
        offset = transform.position - player.transform.position;
    }

    // LateUpdate called after Update each frame
    void LateUpdate()
    {
        //when player position is changed, camera pos will follow suit
        transform.position = player.transform.position + offset;
    }
}
