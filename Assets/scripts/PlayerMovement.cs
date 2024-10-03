using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigB;
    public int PlayerSpeed = 2;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        PlayerSpeed /= 2;
        Debug.Log(rigB.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            rigB.velocity =  Vector2.up * PlayerSpeed;
        }
        else
        {
            rigB.velocity += Vector2.up * 0;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            rigB.velocity += Vector2.down * PlayerSpeed;
        }
        else
        {
            rigB.velocity += Vector2.up * 0;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            rigB.velocity += Vector2.left * PlayerSpeed;
        }
        else
        {
            rigB.velocity += Vector2.left * 0;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rigB.velocity += Vector2.right * PlayerSpeed;
        }
        else
        {
            rigB.velocity += Vector2.right * 0;
        }
    }
}
