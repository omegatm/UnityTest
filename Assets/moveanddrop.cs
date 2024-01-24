using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveanddrop : MonoBehaviour
{
    public Rigidbody2D rgb2d;
    public float distance;
    public float linearSpeed;
    private float startPosition;
    public float moveSpeed = 5f;
    private Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        startPosition = rgb2d.position.x;
        start = rgb2d.position;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void FixedUpdate()
    {
        if (Input.GetKeyUp("space"))
        {
            rgb2d.MovePosition(start);
        }

            if (Input.GetKey("space"))
        {
            Vector2 newPosition = new Vector2(rgb2d.position.x, rgb2d.position.y - moveSpeed * Time.deltaTime);
            rgb2d.MovePosition(newPosition);
        }
        else
        {
            rgb2d.MovePosition(new Vector2((Mathf.Sin((2 * Mathf.PI * (Time.time * linearSpeed / distance)) - (Mathf.PI / 2)) * (distance / 2) + (distance / 2)) + startPosition, rgb2d.position.y));
        }
    }
}
