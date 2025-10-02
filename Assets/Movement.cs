using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float halfHeight;
    void Start()
    {
        halfHeight = GetComponent<Collider>().bounds.size.y / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (transform.position.y <= 0 + halfHeight)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                movement.y += 1f;
            }
        }
        else
        {
            movement.y -= 0.005f;
        }
        // Only translate if there's actual movement
        if (movement != Vector3.zero)
        {
            transform.Translate(movement);
        }
    }
}
