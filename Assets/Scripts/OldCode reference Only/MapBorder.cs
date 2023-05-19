using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBorder : MonoBehaviour
{
    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z = transform.position.z;
        x = transform.position.x;
        y = transform.position.y;
        if(transform.position.x > 20f)
        {
            x = 20f;
        }
        if (transform.position.x < -20f)
        {
            x = -20f;
        }
        if (transform.position.z > 15f)
        {
            z = 15f;
        }
        if (transform.position.z < -10f)
        {
            z = -10f;
        }
        transform.position = new Vector3(x,y,z);
    }
}
