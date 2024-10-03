using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigB;
    public int PlayerSpeed;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rigB.velocity = Vector2.up * 0;
        if (Input.GetKey(KeyCode.W) == true)
        {
            rigB.velocity =  Vector2.up * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            rigB.velocity += Vector2.down * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            rigB.velocity += Vector2.left * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rigB.velocity += Vector2.right * PlayerSpeed;
        }
    }
}
