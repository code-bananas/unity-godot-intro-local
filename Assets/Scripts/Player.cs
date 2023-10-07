using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }
    }
}
