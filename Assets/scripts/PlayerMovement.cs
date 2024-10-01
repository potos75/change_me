using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigB;
    public int PlayerSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            rigB.velocity += Vector2.up * PlayerSpeed;
        }
        else
        {
            rigB.velocity += Vector2.up * 0;
        }
    }
}
