using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowHelper : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerCamera;
    void Start()
    {
        transform.rotation = Quaternion.Euler(playerCamera.transform.eulerAngles.x, playerCamera.transform.eulerAngles.y, 0);
        transform.position = new Vector3(playerCamera.transform.position.x, playerCamera.transform.position.y, playerCamera.transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(playerCamera.transform.eulerAngles.x, playerCamera.transform.eulerAngles.y, 0);
        transform.position = new Vector3(playerCamera.transform.position.x, playerCamera.transform.position.y, playerCamera.transform.position.z);
    }
}
