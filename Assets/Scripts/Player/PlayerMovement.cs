using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rig;
    private float playerspeed;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        playerspeed = GetComponent<PlayerStats>().speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.drag = 100;
        if (Input.GetKey(KeyCode.W))
        {
            rig.drag = 0;
            transform.Translate(Vector3.forward * GetComponent<PlayerStats>().speed * Time.deltaTime);
            rig.velocity = (transform.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.drag = 0;
            transform.Translate(Vector3.back * GetComponent<PlayerStats>().speed * Time.deltaTime);
            rig.velocity = -transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.drag = 0;
            transform.Translate(Vector3.left * GetComponent<PlayerStats>().speed * Time.deltaTime);
            rig.velocity = -transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.drag = 0;
            transform.Translate(Vector3.right * GetComponent<PlayerStats>().speed * Time.deltaTime);
            rig.velocity = transform.right;
        }
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
    }
}
