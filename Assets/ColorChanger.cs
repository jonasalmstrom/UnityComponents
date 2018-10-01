using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public TrailRenderer trailRend;
    public SpriteRenderer rend;
    public Color color;

    // Use this for initialization
    void Start()
    {
        rend.color = color;
        rend.color = new Color(0.2f, 1, 0.2f);

        //transform.position = new Vector3(-5f, transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = new Color(0.2f, 1, 0.2f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(movementSpeed / 2 * Time.deltaTime, 0, 0, Space.Self);
            rend.color = new Color(1f, 0f, 0f);
            trailRend.endColor = new Color(1, 0, 1);
        }

        

        //transform.Translate(-2f * Time.deltaTime, 0, 0, Space.Self);
    }
}
