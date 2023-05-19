using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimGun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject launchPoint;
    public GameObject bullet;
    public GameObject flash;
    public GameObject flashPoint;
    private Rigidbody rig;
    private float timer;
    private float timerMax;
    private bool canShoot;
    void Start()
    {
        timer = 0f;
        timerMax = .5f;
        canShoot = true;
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * 1.5f * Input.GetAxis("Mouse Y") * -1);
        transform.Rotate(Vector3.up * 1.5f * Input.GetAxis("Mouse X"));
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        if (Input.GetMouseButtonDown(0))
        {
            if (canShoot && GetComponent<PlayerStats>().ammo > 0)
            {
                Instantiate(bullet, launchPoint.transform.position, transform.rotation);
                Instantiate(flash, flashPoint.transform.position, transform.rotation);
                GetComponent<PlayerStats>().ammo -= 1;
                canShoot = false;
                timer = 0;
            }
        }
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            canShoot = true;
        }
    }
}
