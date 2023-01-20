using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    CharacterController charCtrl;
    Vector2 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        charCtrl = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            moveDir = new Vector2(0.0f, 1.0f);
            charCtrl.Move(moveDir);
            Debug.Log("Player up");
        }
    }
}
