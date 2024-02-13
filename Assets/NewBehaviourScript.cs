using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Vector2 vector2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        print(horizontal);
        vector2 = new Vector2(transform.position.x + speed * horizontal * Time.deltaTime, transform.position.y);
        rb.MovePosition(vector2);
    }
}
